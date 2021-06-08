using Newtonsoft.Json;
using System;

namespace APITestApp
{
    // add a constraint to our generic type, so that it only can be of certain types
    // the new constraint specifies that a type argument MUST have a parameterless constructor
    //The type cannot be abstract, and has to implement the IResponse interface
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        //
        public ResponseType Response { get; set; }  

        public void DeserialiseResponse(string postcodeResponse)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(postcodeResponse);
        }
    }
}