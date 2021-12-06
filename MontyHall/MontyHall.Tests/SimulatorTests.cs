using MontyHall.Enums;
using MontyHall.Interfaces;
using Xunit;

namespace MontyHall.Tests
{
    public class SimulatorTests
    {
        [Fact]
        public void RunSimulator_WhenInputIsANum_RunTimesAreSameAsInputNum()
        {
            //arrange
            var simulator = new MockSimulator();
            var runTime = 1000;
            //act
            simulator.RunSimulator(runTime);
            //assert
            Assert.Equal(runTime, simulator.runCount);
        }
    }
}