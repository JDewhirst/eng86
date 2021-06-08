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
        public ICallManager CallManager { get; set; }
        public JObject JSON_Response { get; set; }
        public string OutcodeSelected { get; set; }
        public DTO<SingleOutcodeResponse> OutcodeDTO { get; set; }
        public string OutcodeResponse { get; set; }

        public SingleOutcodeService(ICallManager callManager)
        {
            CallManager = callManager;
            OutcodeDTO = new DTO<SingleOutcodeResponse>();
        }

        public async Task MakeRequestAsync(string outcode)
        {

            OutcodeSelected = outcode;

            OutcodeResponse = await CallManager.MakeOutcodeRequestAsync(outcode);

            // Parse JSON response content
            JSON_Response = JObject.Parse(OutcodeResponse);

            OutcodeDTO.DeserialiseResponse(OutcodeResponse);
        }
    }
}
