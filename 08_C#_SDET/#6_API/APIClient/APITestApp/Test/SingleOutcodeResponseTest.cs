using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace APITestApp
{
    public class SingleOutcodeResponseTest
    {
        private SingleOutcodeService _singleOutcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singleOutcodeService = new SingleOutcodeService();
            await _singleOutcodeService.MakeRequestAsync("YO10");
        }

        //The response code will not always be returned in the response body
        [Test]
        public void StatusIs200()
        {
            Assert.That(_singleOutcodeService.JSON_Response["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void StatusIs200_alt()
        {
            Assert.That(_singleOutcodeService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Test]
        public void AdminDistrict_IsYork()
        {
            Assert.That(_singleOutcodeService.JSON_Response["result"]["admin_district"].ToString(), Is.EqualTo("York"));
        }
    }
}

