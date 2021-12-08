using System;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class Simulator : ISimulator
    {
        private double _stayCount = 0;
        private double _switchCount = 0;
        private double _runCount;
        private string printResults;

        private double switchPercent;
        private double stayPercent;
        
        public void RunSimulator(int runTimes, IGame gameStay, IGame gameSwitch)
        {
            _runCount = runTimes;
            for (var i = 0; i < runTimes; i++)
            {
                _stayCount += GetGameRunning(gameStay);
                _switchCount += GetGameRunning(gameSwitch);
            }
        }

        private static int GetGameRunning(IGame game)
        {
            var count = 0;
            game.RunGame();
            if (game.GetResults())
            {
                count++;
            }
            game.ClearCurrentGame();
            return count;
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