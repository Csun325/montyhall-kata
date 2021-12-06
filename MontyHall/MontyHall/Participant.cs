using System;
using System.Diagnostics;
using MontyHall.Enums;
using MontyHall.Interfaces;

namespace MontyHall
{
    public class Participant : IParticipant
    {
        private readonly IRandom _rnd;
        private readonly Strategy _strategy;
        private bool _winResult;

        public Participant(IRandom rnd, Strategy strategy)
        {
            _rnd = rnd;
            _strategy = strategy;

        }

       
        public int ChooseFirstDoor(int totalDoors)
        {
            return _rnd.SelectRandom(totalDoors);
        }

        public int SecondDoorStrategy(int currentDoor, int totalDoors)
        {
            return _strategy switch
            {
                Strategy.Stay => currentDoor,
                Strategy.Switch => -1,
                // indicate switch using -1
                _ => throw new ArgumentOutOfRangeException()
            };
        }

    }
}