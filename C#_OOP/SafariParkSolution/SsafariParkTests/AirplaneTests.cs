using NUnit.Framework;
using System;
using SafariPark;

namespace SafariParkTests
{
    class AirplaneTests
    {

        [Test]
        public void WhenAnAirplaneDescendsBelow0ItThrowsCrashException()
        {
            Assert.Fail();
        }

        [TestCase()]
        public void AirplaneNoArgumentsMoveTest()
        {
            Airplane a = new Airplane(100, 20, "SaharaAir");
            Assert.AreEqual($"Moving along at an altitude of {0} metres.", a.Move());
        }

        [TestCase(3,3)]
        [TestCase(0,0)]
        [TestCase(10,10)]
        public void AirplaneOneArgumentMoveTest(int times, int expected)
        {
            Airplane a = new Airplane(100, 20, "SaharaAir");
            Assert.AreEqual($"Moving along {expected} times at an altitude of {0} metres.", a.Move(times));
        }

        [Test]
        public void AirplaneToStringTest()
        {
            Airplane a = new Airplane(100, 20, "SaharaAir") { NumPassengers = 50,};
            Assert.AreEqual("Thank you for flying SaharaAir: SafariPark.Airplane capacity: 100 passengers: 50 speed: 20 position: 0 altitude: 0."
                            , a.ToString()
                            );
        }
    }
}
