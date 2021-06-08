using NUnit.Framework;
using System;
using System.Threading.Tasks;
namespace APITestApp
{
  
    public class WhenTheSinglePostcodeServiceIsCalled_WithValidPostcode
    {
        private SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("EC2Y 5AS");
        }

        //The response code will not always be returned in the response body
        [Test]
        public void StatusIs200()
        {
            Assert.That(_singlePostcodeService.JSON_Response["status"].ToString(), Is.EqualTo("200"));
        }

        [Test]
        public void StatusIs200_alt()
        {
            Assert.That(_singlePostcodeService.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Test]
        public void StatusIs200_alt2()
        {
            Assert.That(_singlePostcodeService.SinglePostcodeDTO.Response.Status, Is.EqualTo(200));
        }

        [Test]
        public void AdminDistrict_IsCityOfLondon()
        {
            Assert.That(_singlePostcodeService.SinglePostcodeDTO.Response.result.admin_district, Is.EqualTo("City of London"));
        }

        [Test]
        public void NumberOfCodes_IsCorrect()
        {
            Assert.That(_singlePostcodeService.CodeCount(), Is.EqualTo(12));
        }
    }


    public class WhenTheSinglePostcodeServiceIsCalled_WithInValidPostcode
    {
        private SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("666666");
        }

        [Test]
        public void StatusDescription_IsNotFound()
        {
            Assert.That(_singlePostcodeService.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }

        [Test]
        public void StatusIs404()
        {
            Assert.That(_singlePostcodeService.JSON_Response["status"].ToString(), Is.EqualTo("404"));
        }

        [Test]
        public void ErrorIsInvalid_postcode()
        {
            Assert.That(_singlePostcodeService.JSON_Response["error"].ToString(), Is.EqualTo("Invalid postcode"));
        }
    }

    
    public class WhenTheSinglePostcodeServiceIsCalled_WithNoPostcode
    {
        private SinglePostcodeService _singlePostcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singlePostcodeService = new SinglePostcodeService();
            await _singlePostcodeService.MakeRequestAsync("");
        }

        [Test]
        public void StatusDescription_IsNotFound()
        {
            Assert.That(_singlePostcodeService.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Test]
        public void StatusIs404()
        {
            Assert.That(_singlePostcodeService.JSON_Response["status"].ToString(), Is.EqualTo("400"));
        }

        [Test]
        public void ErrorIsInvalid_postcode()
        {
            Assert.That(_singlePostcodeService.JSON_Response["error"].ToString(), Is.EqualTo("No postcode query submitted. Remember to include query parameter"));
        }
    }

}
