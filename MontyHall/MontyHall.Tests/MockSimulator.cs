using MontyHall.Interfaces;

namespace MontyHall.Tests
{
    public class MockSimulator : ISimulator
    {
        public int runCount = 0;
        public void RunSimulator(int runTimes)
        {
            for (var i = 0; i < runTimes; i++)
            {
                runCount++;
            }
        }
    }
}