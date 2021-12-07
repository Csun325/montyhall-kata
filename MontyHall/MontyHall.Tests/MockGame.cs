using System.Collections.Generic;
using MontyHall.Interfaces;

namespace MontyHall.Tests
{
    public class MockGame : IGame
    {
        public int gamesRun = 0;
        public bool results { get; set; }
        public int resultTimes = 0;
        
        public void RunGame()
        {
            gamesRun++;
        }

        public bool GetResults()
        {
            if (results == true)
            {
                resultTimes++;
            }
            return results;
        }

        public void ClearCurrentGame()
        {
            
        }

        public void CreateDoors()
        {
            throw new System.NotImplementedException();
        }

        public void RandomisePrizePos()
        {
            throw new System.NotImplementedException();
        }

        public void GetFirstDoor()
        {
            throw new System.NotImplementedException();
        }

        public void GetSecondDoor()
        {
            throw new System.NotImplementedException();
        }

        public List<Door> GetDoors()
        {
            throw new System.NotImplementedException();
        }

        public void ShowDoor()
        {
            throw new System.NotImplementedException();
        }

        public int GetFirstDoorIndex()
        {
            throw new System.NotImplementedException();
        }
    }
}