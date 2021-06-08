using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace APITestApp
{
    class BulkPostcodeResponseTest
    {
        private BulkPostcodeService _bulkPostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _bulkPostcodeService = new BulkPostcodeService();
            await _bulkPostcodeService.MakeRequestAsync(new string[] { "OX49 5NU", "M32 0JG", "NE30 1DP" });
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_bulkPostcodeService.JSON_Response["status"].ToString(), Is.EqualTo("200"));
        }

        public void StatusIs200_Alt()
        {
            Assert.That(_bulkPostcodeService.StatusCode, Is.EqualTo("200"));
        }
        [Test]
        public void ObjectStatusDescription_IsOk()
        {
            Assert.That(_bulkPostcodeService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        //[Test]
        //public void RegionForOX495NUIsCorrect()
        //{
        //    var selectedLocation = _bulkPostcodeService.JSON_Response["result"].Where(x => x["query"] == "OX49 5NU").FirstOrDefault();
        //    Assert.That(selectedLocation.result.region, Is.EqualTo("South East"));
        //}
    }
}
