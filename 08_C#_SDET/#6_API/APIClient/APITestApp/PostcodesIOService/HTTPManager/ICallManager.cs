using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APITestApp
{
    public interface ICallManager
    {
        
        string StatusDescription { get; set; }

        Task<string> MakePostcodeRequestAsync(string postcode);

        Task<string> MakeOutcodeRequestAsync(string outcode);

        Task<string> MakeBulkPostcodeRequestAsync(string[] postcodes);
    }
}
