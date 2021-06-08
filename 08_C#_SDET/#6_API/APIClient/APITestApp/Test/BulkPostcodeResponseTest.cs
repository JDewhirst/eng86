using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.Test
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
            Assert.That(_bulkPostcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        public void StatusIs200_Alt()
        {
            Assert.That(_bulkPostcodeService.StatusCode, Is.EqualTo("200"));
        }
        [Test]
        public void ObjectStatusIs200()
        {
            Assert.That(_bulkPostcodeService.ResponseObject.status, Is.EqualTo(200));
        }

        [Test]
        public void RegionForOX495NUIsCorrect()
        {
            var selectedLocation = _bulkPostcodeService.ResponseObject.result.Where(x => x.query == "OX49 5NU").FirstOrDefault();
            Assert.That(selectedLocation.result.region, Is.EqualTo("South East"));
        }
    }
}
