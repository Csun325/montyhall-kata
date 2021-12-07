using MontyHall.Interfaces;

namespace MontyHall.Tests
{
    public class MockSimulator : ISimulator
    {
        public void RunSimulator(int runTimes, IGame gameStay, IGame gameSwitch)
        {
            throw new System.NotImplementedException();
        }

        public void CompareResults()
        {
            throw new System.NotImplementedException();
        }
    }
}