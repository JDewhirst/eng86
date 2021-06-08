using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace APITestApp
{
    #region
    //Make a request to the API
    //Store the returned data
    //Get this data so it can be used in tests
    //Store and use configuration information
    #endregion
    public class SinglePostcodeService
    {
        #region Properties
        //Restsharp object which handles comms with the API
        public RestClient Client;
        //Newstonsoft object representing the json response
        public JObject ResponseContent { get; set; }
        // the postcode used in the API request
        public string PostcodeSelected { get; set; }
        //Store the status code
        public string StatusCode { get; set; }
        //An Object model of the response
        public SinglePostcodeResponse ResponseObject { get; set; }

        #endregion

        public SinglePostcodeService()
        {
            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
        }

        public async Task MakeRequestAsync(string postcode)
        {
            //set up the request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type","application/json");
            PostcodeSelected = postcode;

            //Define the resource path
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            //Execute the request and store the response
            var response = await Client.ExecuteAsync(request);

            // Parse JSON response content
            ResponseContent = JObject.Parse(response.Content);

            //Capture the status code
            StatusCode = response.StatusCode.ToString();

            //Parse JSON in an onject
            ResponseObject = JsonConvert.DeserializeObject<SinglePostcodeResponse>(response.Content);
        }
    }
}
