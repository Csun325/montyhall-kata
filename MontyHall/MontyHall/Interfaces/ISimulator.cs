namespace MontyHall.Interfaces
{
    public interface ISimulator
    {
        public void RunSimulator(int runTimes, IGame gameStay, IGame gameSwitch);
        public void CompareResults();
    }
}