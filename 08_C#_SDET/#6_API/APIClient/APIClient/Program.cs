using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace APIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            /////SINGLE POST CODE REQUEST & RESPONSE/////
            #region
            //Our client property id equal to a new RestSharp Object (which is part of the restsharp library - obviosuly)
            //Create a URI object. It encapsulate all the information we need to bake the API call.
            //It allows us to send authenticated HTTP requests
            #endregion
            var restClient = new RestClient("https://api.postcodes.io/");

            #region
            //setup the request. We are going to create a request object
            #endregion
            var restRequest = new RestRequest();
            //Set method as GET
            restRequest.Method = Method.GET;
            #region
            //We are now going to add our Request Header. Specfiy the content-type
            #endregion
            restRequest.AddHeader("Content-Type","application/json");
            #region
            //Set the time out so that it is set to inifnity
            #endregion
            restRequest.Timeout = -1;
            #region
            //We are going to now set up the resource EC2y 5AS
            //Get rid of all spaced and put it all to lower case
            #endregion
            var postcode = "EC2Y 5AS";
            restRequest.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";
            #region
            //Now we are going to use our RestClient 
            //to execute our request and store the Response
            #endregion
            var singleResponse = restClient.Execute(restRequest);
            //Console.WriteLine("Rest Response content (as string)");
            //Console.WriteLine(singleResponse.Content);

            /////BULK POST CODE REQUEST & RESPONSE/////
            #region
            //Create a JOjbect 
            JObject postcodes = new JObject
                {
                    new JProperty("postcodes", new JArray(new string[]{ "OX49 5NU", "M32 0JG", "NE30 1DP" }))
                };
            #endregion
            var client = new RestClient("https://api.postcodes.io/postcodes/");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(postcodes.ToString());
            IRestResponse bulkResponse = await client.ExecuteAsync(request);
            //Console.WriteLine(bulkResponse.Content);

            /////Parse our bulkResponse to a JOBject and query that JObect/////
            var bulkJsonResponse = JObject.Parse(bulkResponse.Content);
            //Console.WriteLine(bulkJsonResponse["status"]);
            //Console.WriteLine(bulkJsonResponse["result"][0]["query"]);
            //Console.WriteLine(bulkJsonResponse["result"][0]["result"]["region"]);

            /////DESERIALISE RESPONSE TO C# OBJECT/////

            var singlePostcode = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singleResponse.Content);
            var bulkPostcodes = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkResponse.Content);

            Console.WriteLine("Single Postcode response:");
            Console.WriteLine(singlePostcode.Status);
            Console.WriteLine(singlePostcode.result.region);
            Console.WriteLine();
            Console.WriteLine("Bulk postcode response:");
            Console.WriteLine(bulkPostcodes.status);
            foreach (var result in bulkPostcodes.result)
            {
                Console.WriteLine(result.query);
                Console.WriteLine(result.result.region);
            }
        }
    }
}
