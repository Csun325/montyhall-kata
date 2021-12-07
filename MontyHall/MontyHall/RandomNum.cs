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
        
        //returns random value from 0 to 
        public int SelectRandom(int end)
        {
            return _rnd.Next(end);
        }
    }
}