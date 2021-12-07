using MontyHall.Interfaces;

namespace MontyHall.Tests
{
    public class MockRandom : IRandom
    {
        public int SelectRandom(int end)
        {
            return 1;
        }
    }
}