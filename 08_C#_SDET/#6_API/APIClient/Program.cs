using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //// SINGLE POST CODE REQUEST & RESPONSE ////
            #region
            // our client property is equal to a new REstSharp Object (which is part of the restsharp library)
            //Create a URI object. It encapsulates all the information we need to make the API call.
            // It allows us to send authenticated HTTP requests.
            #endregion

            var restClient = new RestClient(@"https://api.postcodes.io/");

            #region
            // setup the request, we are going to create a request object
            var restRequest = new RestRequest();
            // Set method as GET
            restRequest.Method = Method.GET;
            #endregion

            // Add a Request header.
            restRequest.AddHeader("Content-Type", "application/json");

            // Set the time out so that it is set to infinity
            restRequest.Timeout = -1;

            // Now set up the resource EC2Y5AS
            // GEt rid of all spaces and lower case
            var postcode = "EC2Y 5AS";
            restRequest.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            //  Now use our RestClient to execute our request and store the response

            var singleResponse = restClient.Execute(restRequest);

            //Console.WriteLine("Rest response context as string");
            //Console.WriteLine(singleResponse.Content);

            //JObject table = (JObject)singleResponse.Content;
            //Console.WriteLine("Rest response as json");


            //// BULK POST CODE REQUEST & RESPONSE ////
            #region
            ///

            // Create a JObject
            JObject postcodes = new JObject
                {
                    new JProperty("postcodes", new JArray( new string[]{ "OX49 5NU", "M32 0JG", "NE30 1DP"}))
                };

            var client = new RestClient("https://api.postcodes.io/postcodes");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(postcodes.ToString());
            IRestResponse bulkResponse = client.Execute(request);
            //Console.WriteLine(bulkResponse.Content);

            // Parse our bukResponse to a JObject and query that JObject
            var bulkJsonResponse = JObject.Parse(bulkResponse.Content);
            //Console.WriteLine(bulkJsonResponse["result"][0]["result"]["region"]);
            #endregion

            ////DESERIALIZE RESPONSE TO C# OBJECT////
            #region
            ///
            var singlePostcode = JsonConvert.DeserializeObject<SinglePostCodeResponse>(singleResponse.Content);
            var bulkPostcode = JsonConvert.DeserializeObject<BulkPostCodeResponse>(bulkResponse.Content);

            //Console.WriteLine("Single Postcode response:");
            //Console.WriteLine(singlePostcode.Status);
            //Console.WriteLine("EU electoral region: " + singlePostcode.result.european_electoral_region);

            //Console.WriteLine("Bulk Postcode response:");
            //Console.WriteLine(bulkPostcode.status);
            //foreach (var item in bulkPostcode.result)
            //{
            //    Console.WriteLine(item.query);
            //    Console.WriteLine(item.result.european_electoral_region);
            //}
            #endregion

            //// OUTWARD ////
            var outwardClient = new RestClient("https://api.postcodes.io/outcodes/yo10");
            outwardClient.Timeout = -1;
            var outwardRequest = new RestRequest(Method.GET);
            IRestResponse outwardResponse = outwardClient.Execute(outwardRequest);
            Console.WriteLine(outwardResponse.Content);

            var outwardPostcode = JsonConvert.DeserializeObject<OutwardCodeResponse>(outwardResponse.Content);
            Console.WriteLine(outwardPostcode.result.latitude + " " + outwardPostcode.result.longitude) ;
        }
    }
}
