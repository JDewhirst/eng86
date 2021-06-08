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
        // Call manager - we can access the method and it's propertis
        public ICallManager CallManager { get; set; }
        //Newstonsoft object representing the json response
        public JObject JSON_Response { get; set; }
        // the postcode used in the API request
        public string PostcodeSelected { get; set; }
        //Data transfer object - it will be a generic type, but we will specify the stype we want
        public DTO<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }
        //Response content as a string
        public string PostcodeResponse { get; set; }

        #endregion

        public SinglePostcodeService(ICallManager callManager)
        {
            CallManager = callManager;
            SinglePostcodeDTO = new DTO<SinglePostcodeResponse>();
        }

        public async Task MakeRequestAsync(string postcode)
        {

            PostcodeSelected = postcode;

            // Make request
            PostcodeResponse = await CallManager.MakePostcodeRequestAsync(postcode);

            // Parse JSON response content
            JSON_Response = JObject.Parse(PostcodeResponse);

            // Use DTO to convert JSON string to an object
            SinglePostcodeDTO.DeserialiseResponse(PostcodeResponse);
        }

        // Helper method
        public int CodeCount()
        {
            return JSON_Response["result"]["codes"].ToList().Count();
        }
    }
}
