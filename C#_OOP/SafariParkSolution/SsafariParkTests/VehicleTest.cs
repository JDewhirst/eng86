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

        [TestCase(10,3,3)]
        [TestCase(4,1,1)]
        public void WhenAVehicleRecievesTooManyPassengersItFillsToCapacity(int numPassengers, int capacity, int expected)
        {
            Vehicle v = new Vehicle(capacity);
            v.NumPassengers = numPassengers;
            Assert.AreEqual(expected, v.NumPassengers);
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
