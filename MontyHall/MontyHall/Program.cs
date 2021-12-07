using System;

namespace MontyHall
{
    static class Program
    {
        static void Main(string[] args)
        {

            const int runTimes = 1000;
            const int totalDoors = 3;
            
            var simulator = Factory.CreateSimulator();
            var gameStay = Factory.CreateGameStay(Factory.CreateRandom(), totalDoors);
            var gameSwitch = Factory.CreateGameSwitch(Factory.CreateRandom(), totalDoors);
            
            simulator.RunSimulator(runTimes, gameStay, gameSwitch);
            simulator.CompareResults();
            
        }
    }
}
