using System;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class Simulator : ISimulator
    {

        public double _stayCount = 0;
        public double _switchCount = 0;
        public double _runCount;
        public string printResults;

        public double switchPercent;
        public double stayPercent;
        
        public void RunSimulator(int runTimes, IGame gameStay, IGame gameSwitch)
        {
            _runCount = runTimes;
            for (var i = 0; i < runTimes; i++)
            {
                Console.WriteLine("Round " + i);
                Console.WriteLine("Performing staying strategy_______");
                gameStay.RunGame();
                if (gameStay.GetResults())
                {
                    _stayCount++;
                }
                gameStay.ClearCurrentGame();
                
                Console.WriteLine("Performing switching strategy_______");
                gameSwitch.RunGame();
                if (gameSwitch.GetResults())
                {
                    _switchCount++;
                }
                gameSwitch.ClearCurrentGame();
                
            }
        }

        public void CompareResults()
        {
            stayPercent = Math.Round(_stayCount / _runCount * 100, MidpointRounding.AwayFromZero);
            switchPercent = Math.Round(_switchCount / _runCount * 100, MidpointRounding.AwayFromZero);

            var percent = switchPercent - stayPercent;
            printResults = percent switch
            {
                > 0 => "\nThe Switching Strategy Performs better",
                0 => "\nThe Staying and Switching Strategy performs the same",
                < 0 => "\nThe Staying Strategy Performs better",
                _ => printResults
            };

            Console.WriteLine(printResults);
            Console.WriteLine($"Switching success rate: {switchPercent}%");
            Console.WriteLine($"Staying success rate: {stayPercent}%");
        }
        
        
    }
}