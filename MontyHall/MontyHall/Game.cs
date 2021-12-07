using System;
using System.Collections.Generic;
using System.Diagnostics;
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
           
            GetFirstDoor();
            //Console.WriteLine("first door is chosen");
            
            ShowDoor();
            //Console.WriteLine("Game host now reveals another door!");
            
            GetSecondDoor();
           // Console.WriteLine("Strategy used");
            PrintDoorsStatus();
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

        private int GetRandomDoorByCondition(bool isShow)
        {
            List<int> selectedIndex = new List<int>();
            for (var i = 0; i < _totalDoors; i++)
            {
                var door = _doors[i];
                switch (isShow)
                {
                    case true:
                        if (GetShowDoorCondition(door))
                        {
                            selectedIndex.Add(i);
                        }
                        break;
                    case false:
                        if (GetSecondDoorCondition(door))
                        {
                            selectedIndex.Add(i);
                        }
                        break;
                }
            }
            
            var randomIndex = _rnd.SelectRandom(selectedIndex.Count);
            return selectedIndex[randomIndex];
        }

        private static bool GetShowDoorCondition(Door door)
        {
            return (door.IsPicked == false && door.HasPrize == false);
        }

        private static bool GetSecondDoorCondition(Door door)
        {
            return (door.IsPicked == false && door.IsOpen == false);
        }


        private void ShowDoor()
        {
            var doorIndex = GetRandomDoorByCondition(true);
            _doors[doorIndex].IsOpen = true;

        }


        private void GetSecondDoor()
        {
            var doorIndex = _participant.SecondDoorStrategy(_firstDoorIndex, _totalDoors);
            if (doorIndex == -1) // negative indicated switch
            {
                var doorGet = GetRandomDoorByCondition(false);
                
                _doors[doorGet].IsPicked = true;
                _doors[doorGet].IsOpen = true;
                
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
                if (doorIndex == _firstDoorIndex)
                {
                    message += " picked initially";
                }
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
                }
                Console.WriteLine(message);
            }
        }

        public bool GetResults()
        {
            var winStatus = _doors.Any(d => d.IsOpen && d.HasPrize);
            Console.WriteLine($"Game won:  {winStatus}");
            return winStatus;
        }

        public void ClearCurrentGame()
        {
            _doors.Clear();
            
        }

        // public List<Door> GetDoors()
        // {
        //     return _doors;
        // }
        //
        // public int GetFirstDoorIndex()
        // {
        //     return _firstDoorIndex;
        // }
    }
}