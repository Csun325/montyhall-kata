using System;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class Simulator : ISimulator
    {

        //run each game 1000 time
        public void RunSimulator(int runTimes)
        {
            for (var i = 0; i < runTimes; i++)
            {
                var gameStay = Factory.CreateGameStay(Factory.CreateRandom(), 3);
                var gameSwitch = Factory.CreateGameSwitch(Factory.CreateRandom(), 3);
                
                // check if method is called
                gameStay.RunGame();
                gameSwitch.RunGame();
            }
        }
    }
}