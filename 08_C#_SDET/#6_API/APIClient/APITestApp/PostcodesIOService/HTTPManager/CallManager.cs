using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APITestApp
{
    public class CallManager : ICallManager
    {
        //Restharp object which handles comms with the API
        private readonly IRestClient _client;
        // Capture status descriptiond
        public string StatusDescription { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakePostcodeRequestAsync(string postcode)
        {
            //set up the request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");

            //Define the resource path
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            //Execute the request and store the response
            var response = await _client.ExecuteAsync(request);

            //Capture the status code
            StatusDescription = response.StatusDescription.ToString();

            return response.Content;
        }

        public async Task<string> MakeOutcodeRequestAsync(string outcode)
        {
            //set up the request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");

            //Define the resource path
            request.Resource = $"outcodes/{outcode.ToLower().Replace(" ", "")}";

            //Execute the request and store the response
            var response = await _client.ExecuteAsync(request);

            //Capture the status code
            StatusDescription = response.StatusDescription.ToString();

            return response.Content;
        }

        public async Task<string> MakeBulkPostcodeRequestAsync(string[] postcodes)
        {
            //set up the request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.Resource = "/postcodes";
            var postcodesJson = new JObject
            {
                new JProperty ( "postcodes", new JArray { postcodes } )
            };
            request.AddJsonBody(postcodesJson.ToString());

            //Define the resource path
            request.Resource = $"postcodes/";

            //Execute the request and store the response
            var response = await _client.ExecuteAsync(request);

            //Capture the status code
            StatusDescription = response.StatusDescription.ToString();

            return response.Content;
        }
    }
}
