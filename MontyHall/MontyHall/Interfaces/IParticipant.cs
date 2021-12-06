namespace MontyHall.Interfaces
{
    public interface IParticipant
    {
        public int ChooseFirstDoor(int totalDoors);
        public int SecondDoorStrategy(int currentDoor, int totalDoors);
    }
}