using System;
using System.Collections.Generic;
using System.Linq;
using MontyHall.Interfaces;

namespace MontyHall
{
   
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
            Console.WriteLine("New Game");
            CreateDoors();
            RandomisePrizePos();
           // PrintDoorsStatus();
            GetFirstDoor();
            //Console.WriteLine("first door is chosen");
            //PrintDoorsStatus();
            ShowDoor();
            //Console.WriteLine("Game host now reveals another door!");
            //PrintDoorsStatus();
            GetSecondDoor();
           // Console.WriteLine("Strategy used");
            PrintDoorsStatus();
            
            // clear all status from this game
        }

        private void CreateDoors()
        {
            for (var i = 0; i < _totalDoors; i++)
            {
                _doors.Add(Factory.CreateDoor());
            }
        }

        private void RandomisePrizePos()
        {
            var index = _rnd.SelectRandom(_totalDoors);
            _doors[index].HasPrize = true;
        }

        private void GetFirstDoor()
        {
            var doorIndex = _participant.ChooseFirstDoor(_totalDoors);
            _firstDoorIndex = doorIndex;
            _doors[doorIndex].IsPicked = true;
        }

        private void ShowDoor()
        {
            var doorIndex = _doors.FindIndex(d => d.IsPicked == false && d.HasPrize == false);
            
            _doors[doorIndex].IsOpen = true;
            
        }

        private void GetSecondDoor()
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
                _doors[doorIndex].IsOpen = true;
            }
        }

        private void PrintDoorsStatus()
        {
            foreach (var door in _doors)
            {
                var doorIndex = _doors.IndexOf(door);
                var message = $"Door: {doorIndex + 1}";
                if (door.IsOpen)
                {
                    message += " is open and";
                    if(door.HasPrize)
                    {
                        message += " has the prize!";
                    }
                    else
                    {
                        message += " has no prize";
                    }
                }
                else 
                {
                    message += " is closed";
                    if (door.IsPicked)
                    {
                        message += " and is picked initially";
                    }
                }
                Console.WriteLine(message);
            }
        }

        public bool GetResults()
        {
            return _doors.Any(d => d.IsOpen && d.HasPrize);
        }

        public void ClearCurrentGame()
        {
            _doors.Clear();
            
        }

        // public List<Door> GetDoors()
        // {
        //     return _doors;
        // }

        // public int GetFirstDoorIndex()
        // {
        //     return _firstDoorIndex;
        // }
    }
}