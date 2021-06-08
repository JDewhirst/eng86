using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace APITestApp
{
    public class SingleOutcodeServiceTest
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
            Assert.That(_singleOutcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void StatusIs200_alt()
        {
            Assert.That(_singleOutcodeService.StatusCode, Is.EqualTo("OK"));
        }

        [Test]
        public void StatusIs200_alt2()
        {
            Assert.That(_singleOutcodeService.ResponseObject.status, Is.EqualTo(200));
        }

        [Test]
        public void AdminDistrict_IsYork()
        {
            Assert.That(_singleOutcodeService.ResponseObject.result.admin_district[0], Is.EqualTo("York"));
        }
    }
}

