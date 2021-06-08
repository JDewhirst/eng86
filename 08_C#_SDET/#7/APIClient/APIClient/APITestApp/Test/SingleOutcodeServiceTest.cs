using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    public class WhenTheSingleOutcodeServiceIsCalled_WithValidPostcode
    {
        SingleOutcodeService _singleOutcodeService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _singleOutcodeService = new SingleOutcodeService();
            await _singleOutcodeService.MakeRequestAsync("B76");
        }
        [Test]
        public void StatusIs200()
        {
            Assert.That(_singleOutcodeService.ResponseContent["status"].ToString(), Is.EqualTo("200"));
        }
        public void StatusIs200_Alt()
        {
            Assert.That(_singleOutcodeService.StatusCode, Is.EqualTo("200"));
        }


        [Test]
        public void ObjectStatusIs200()
        {
            Assert.That(_singleOutcodeService.ResponseObject.status, Is.EqualTo(200));
        }

        [Test]
        public void AdminDistrictIsBirmingham_ForOutcodeB76_UsingJObject()
        {
            Assert.That(_singleOutcodeService.ResponseContent["result"]["admin_district"][0].ToString(), Is.EqualTo("Birmingham"));
        }

        [Test]
        public void AdminDistrictIsBirmingham_ForOutcodeB76_usingObject()
        {
            Assert.That(_singleOutcodeService.ResponseObject.result.admin_district[0], Is.EqualTo("Birmingham"));
        }
    }
}
