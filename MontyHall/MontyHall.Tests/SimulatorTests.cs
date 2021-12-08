using MontyHall.Enums;
using MontyHall.Interfaces;
using Xunit;

namespace MontyHall.Tests
{
    public class SimulatorTests
    {
        // [Fact]
        // public void RunSimulator_WhenInputIsANum_RunTimesAreSameAsInputNum()
        // {
        //     //arrange
        //     var simulator = new Simulator();
        //     const int runTimes = 1234;
        //     var gameStay = new MockGame();
        //     var gameSwitch = new MockGame();
        //     //act
        //     simulator.RunSimulator(runTimes, gameStay, gameSwitch);
        //     //assert
        //     Assert.Equal(runTimes, gameStay.gamesRun);
        //     Assert.Equal(runTimes, gameSwitch.gamesRun);
        // }
        //
        // [Fact]
        // public void RunSimulator_WhenInputsAreSatisfied_GetResultsCalledAndOutputCorrectly()
        // {
        //     //arrange
        //     var simulator = new Simulator();
        //     const int runTimes = 1000;
        //     var gameStay = new MockGame();
        //     var gameSwitch = new MockGame();
        //     //act
        //     gameStay.results = false;
        //     gameSwitch.results = true;
        //     simulator.RunSimulator(runTimes, gameStay, gameSwitch);
        //     //assert
        //     Assert.Equal(runTimes, gameSwitch.resultTimes);
        //     Assert.Equal(0, gameStay.resultTimes);
        // }
        //
        // [Fact]
        // public void CompareResults_WhenSwitchWinsMoreThenStay_ThenPrintSwitchBetter()
        // {
        //     //arrange
        //     var simulator = new Simulator();
        //     const int runTimes = 1000;
        //     var gameStay = new MockGame();
        //     var gameSwitch = new MockGame();
        //     var message = "\nThe Switching Strategy Performs better";
        //     //act
        //     gameStay.results = false;
        //     gameSwitch.results = true;
        //     simulator.RunSimulator(runTimes, gameStay, gameSwitch);
        //     simulator.CompareResults();
        //     //assert
        //     Assert.Equal(message, simulator.printResults);
        // }
        //
        // [Fact]
        // public void CompareResults_WhenStayWinsMoreThanSwitch_ThenPrintStayBetter()
        // {
        //     //arrange
        //     var simulator = new Simulator();
        //     const int runTimes = 1000;
        //     var gameStay = new MockGame();
        //     var gameSwitch = new MockGame();
        //     var message = "\nThe Staying Strategy Performs better";
        //     //act
        //     gameStay.results = true;
        //     gameSwitch.results = false;
        //     simulator.RunSimulator(runTimes, gameStay, gameSwitch);
        //     simulator.CompareResults();
        //     //assert
        //     Assert.Equal(message, simulator.printResults);
        // }
        //
        // [Theory]
        // [InlineData(3, 55, 1000, 0, 6)]
        // [InlineData(10, 33, 50, 20, 66)]
        // [InlineData(45, 333, 1000, 5, 33)]
        // public void CompareResults_WhenInputsAreNums_ReturnsRoundedDouble(
        //     double stayCount, double switchCount, double runCount, int expectedStay, int expectedSwitch)
        // {
        //     //arrange
        //     var simulator = new Simulator();
        //     simulator._stayCount = stayCount;
        //     simulator._switchCount = switchCount;
        //     simulator._runCount = runCount;
        //     //act
        //     simulator.CompareResults();
        //     //assert
        //     Assert.Equal(expectedStay, simulator.stayPercent);
        //     Assert.Equal(expectedSwitch, simulator.switchPercent);
        // }
    }
}