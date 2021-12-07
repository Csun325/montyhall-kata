using System;

namespace MontyHall
{
    static class Program
    {
        static void Main(string[] args)
        {

            var simulator = Factory.CreateSimulator();
            var runTimes = 5;
            var totalDoors = 3;
            var gameStay = Factory.CreateGameStay(Factory.CreateRandom(), totalDoors);
            var gameSwitch = Factory.CreateGameSwitch(Factory.CreateRandom(), totalDoors);
            
            simulator.RunSimulator(runTimes, gameStay, gameSwitch);
            simulator.CompareResults();
            
        }
    }
}
