using System.Collections.Generic;

namespace MontyHall.Interfaces
{
    public interface IGame
    {
        public void RunGame();
        public void CreateDoors();
        public void RandomisePrizePos();
        public void GetFirstDoor();
        public void GetSecondDoor();
        public List<Door> GetDoors();
        public void ShowDoor();


        public int GetFirstDoorIndex();
    }
}