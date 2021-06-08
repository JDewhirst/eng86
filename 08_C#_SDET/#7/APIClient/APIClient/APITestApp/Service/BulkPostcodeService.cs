using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    class BulkPostcodeService
    {
        #region Properties
        // Restsharp object which handles communication with the API
        public RestClient Client;
        // A Newtonsoft object representing the json response
        public JObject ResponseContent { get; set; }
        // the postcode used in this API request 
        public string[] PostcodesSelected { get; set; }
        public BulkPostcodeResponse ResponseObject { get; set; }
        public string StatusCode { get; set; }
        #endregion

        // constructor - creates the RestClient object
        public BulkPostcodeService()
        {
            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
        }

        // method that defines and makes the API request, and stores the responses
        public async Task MakeRequestAsync(string[] postcodes)
        {
            // set up the request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.Resource = "/postcodes";
            PostcodesSelected = postcodes;
            var postcodesJson = new JObject
        {
            new JProperty ( "postcodes", new JArray { postcodes } )
        };

            // Add JsonBody
            request.AddJsonBody(postcodesJson.ToString());

            // make request
            IRestResponse response = await Client.ExecuteAsync(request);

            // Parse JSON into response content
            ResponseContent = JObject.Parse(response.Content);

            ResponseObject = JsonConvert.DeserializeObject<BulkPostcodeResponse>(response.Content);

            StatusCode = response.StatusCode.ToString();

        }
    }
}
