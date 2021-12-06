using System;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class RandomNum : IRandom
    {
        private Random _rnd;
        public RandomNum()
        {
            _rnd = new Random();
        }
        
        public int SelectRandom(int end)
        {
            return _rnd.Next(end);
        }
    }
}