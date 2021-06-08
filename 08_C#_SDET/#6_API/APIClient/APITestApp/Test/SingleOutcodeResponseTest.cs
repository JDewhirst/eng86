using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace APITestApp
{
    public class WhenTheSingleOutCodeServiceIsCalled_WithValidOutcode
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
            Assert.That(_singleOutcodeService.JSON_Response["result"]["admin_district"][0].ToString(), Is.EqualTo("York"));
        }

    }

    public class WhenTheSingleOutCodeServiceIsCalled_WithInValidOutcode
    {
        private SingleOutcodeService _singleOutcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singleOutcodeService = new SingleOutcodeService();
            await _singleOutcodeService.MakeRequestAsync("666");
        }

        //The response code will not always be returned in the response body
        [Test]
        public void StatusIs404()
        {
            Assert.That(_singleOutcodeService.JSON_Response["status"].ToString(), Is.EqualTo("404"));
        }

        [Test]
        public void StatusDescriptionIs_NotFound()
        {
            Assert.That(_singleOutcodeService.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }

    public class WhenTheSingleOutCodeServiceIsCalled_WithNoOutcode
    {
        private SingleOutcodeService _singleOutcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singleOutcodeService = new SingleOutcodeService();
            await _singleOutcodeService.MakeRequestAsync(" ");
        }

        //The response code will not always be returned in the response body
        [Test]
        public void StatusIs400()
        {
            Assert.That(_singleOutcodeService.JSON_Response["status"].ToString(), Is.EqualTo("400"));
        }

        [Test]
        public void StatusDescriptionIs_()
        {
            Assert.That(_singleOutcodeService.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Test]
        public void ErrorIs_NoPostcodequerysubmitted()
        {
            Assert.That(_singleOutcodeService.JSON_Response["error"].ToString(), Is.EqualTo("Invalid longitude/latitude submitted"));
        }
    }
}

