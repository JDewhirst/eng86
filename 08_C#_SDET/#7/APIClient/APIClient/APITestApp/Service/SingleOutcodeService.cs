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
    public class SingleOutcodeService
    {
        #region Properties
        // Restsharp object which handles communication with the API
        public RestClient Client;
        // A Newtonsoft object representing the json response
        public JObject ResponseContent { get; set; }
        // the postcode used in this API request 
        public string Outcode { get; set; }
        public string StatusCode { get; set; }
        public SingleOutcodeResponse ResponseObject { get; set; }
        #endregion

        // constructor - creates the RestClient object
        public SingleOutcodeService()
        {
            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
        }

        // method that defines and makes the API request, and stores the responses
        public async Task MakeRequestAsync(string outcode)
        {
            // set up the request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            Outcode = outcode;

            // define request resource path, changing to lowercase and removing any whitespace
            request.Resource = $"outcodes/{outcode.ToLower().Replace(" ", "")}";

            // make request
            IRestResponse response = await Client.ExecuteAsync(request);

            // Parse JSON into response content
            ResponseContent = JObject.Parse(response.Content);

            ResponseObject = JsonConvert.DeserializeObject<SingleOutcodeResponse>(response.Content);

            StatusCode = response.StatusCode.ToString();

        }
    }
}
