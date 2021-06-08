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
    public class SingleOutcodeService
    {
        public RestClient Client;
        public JObject ResponseContent { get; set; }
        public string OutcodeSelected { get; set; }
        public string StatusCode { get; set; }
        public SingleOutcodeResponse ResponseObject { get; set; }

        public SingleOutcodeService()
        {
            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
        }

        public async Task MakeRequestAsync(string outcode)
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            OutcodeSelected = outcode;

            request.Resource = $"outcodes/{outcode.ToLower().Replace(" ", "")}";

            var response = await Client.ExecuteAsync(request);

            // Parse JSON response content
            ResponseContent = JObject.Parse(response.Content);

            //Capture the status code
            StatusCode = response.StatusCode.ToString();

            //Parse JSON in an onject
            ResponseObject = JsonConvert.DeserializeObject<SingleOutcodeResponse>(response.Content);

        }
    }
}
