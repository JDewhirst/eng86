using NUnit.Framework;
using SafariPark;

namespace SafariParkTests
{
    class VehicleTest
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenAVehicleRecievesTooManyPassengersItFillsToCapacity()
        {
            Vehicle v = new Vehicle();
            v.NumPassengers = 10;
            Assert.AreEqual(4, v.NumPassengers);
        }

        [Test]
        public void WhenAVehicleRecievesNegativePassengersItFillsTo0()
        {
            Vehicle v = new Vehicle();
            v.NumPassengers = -5;
            Assert.AreEqual(0, v.NumPassengers);
        }

    }
}
