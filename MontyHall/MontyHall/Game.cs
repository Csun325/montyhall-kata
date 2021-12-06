using System;
using System.Collections.Generic;
using System.Linq;
using MontyHall.Interfaces;

namespace MontyHall
{
    /**
     * Things to change at end
     * make helper methods private
     * remove _firstDoorIndex Property and associated getter method
     * add in print results to startGame method
     */
    public class Game : IGame
    {
        private readonly List<Door> _doors;
        private readonly IRandom _rnd;
        private readonly IParticipant _participant;
        private readonly int _totalDoors;
        
        private int _firstDoorIndex;

        public Game(List<Door> doors, IRandom rnd, IParticipant participant, int totalDoors)
        {
            _doors = doors;
            _rnd = rnd;
            _participant = participant;
            _totalDoors = totalDoors;
        }

        public void RunGame()
        {
            CreateDoors();
            RandomisePrizePos();
            GetFirstDoor();
            ShowDoor();
            GetSecondDoor();
        }

        public void CreateDoors()
        {
            for (var i = 0; i < _totalDoors; i++)
            {
                _doors.Add(Factory.CreateDoor());
            }
        }
        
        public void RandomisePrizePos()
        {
            var index = _rnd.SelectRandom(_totalDoors);
            _doors[index].HasPrize = true;
        }

        public void GetFirstDoor()
        {
            var doorIndex = _participant.ChooseFirstDoor(_totalDoors);
            _firstDoorIndex = doorIndex;
            _doors[doorIndex].IsPicked = true;
        }

        public void ShowDoor()
        {
            var doorIndex = _doors.FindIndex(d => d.IsPicked == false && d.HasPrize == false);
            
            _doors[doorIndex].IsOpen = true;
            
        }

        public void GetSecondDoor()
        {
            var doorIndex = _participant.SecondDoorStrategy(_firstDoorIndex, _totalDoors);
            if (doorIndex == -1) // negative indicated switch
            {
                var door = _doors.First(d => d.IsPicked == false && d.IsOpen == false);
                door.IsPicked = true;
                door.IsOpen = true;
            }
            else // stay
            {
                //_doors[doorIndex].IsPicked = true;
                _doors[doorIndex].IsOpen = true;
            }
        }

        public List<Door> GetDoors()
        {
            return _doors;
        }

        public int GetFirstDoorIndex()
        {
            return _firstDoorIndex;
        }
    }
}