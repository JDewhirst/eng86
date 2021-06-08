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
    public class BulkPostcodeService
    {
        public ICallManager CallManager { get; set; }
        public JObject JSON_Response { get; set; }
        public string[] PostcodesSelected { get; set; }
        public string StatusCode { get; set; }
        public DTO<BulkPostcodeResponse> BulkPostcodeDTO { get; set; }
        public string BulkPostcodeResponse { get; set; }

        public BulkPostcodeService(ICallManager callManager)
        {
            CallManager = callManager;
            BulkPostcodeDTO = new DTO<BulkPostcodeResponse>();
        }

        // method that defines and makes the API request, and stores the responses
        public async Task MakeRequestAsync(string[] postcodes)
        {

            PostcodesSelected = postcodes;
            BulkPostcodeResponse = await CallManager.MakeBulkPostcodeRequestAsync(postcodes);
            // Parse JSON into response content
            JSON_Response = JObject.Parse(BulkPostcodeResponse);

            BulkPostcodeDTO.DeserialiseResponse(BulkPostcodeResponse);

        }

    }
}
