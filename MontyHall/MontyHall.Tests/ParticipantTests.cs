using MontyHall.Enums;
using MontyHall.Interfaces;
using Xunit;

namespace MontyHall.Tests
{
    public class ParticipantTests
    {
        
        [Fact]
        public void ChooseFirstDoor_WhenCalled_ReturnIntegerWithinRange()
        {
            //arrange
            var participant = new Participant(new RandomNum(), Strategy.Stay);
            int totalDoors = 3;
            //act
            var result = participant.ChooseFirstDoor(totalDoors);
            //assert
            Assert.InRange(result, 0, totalDoors);
        }

        [Fact]
        public void SecondDoorStrategy_WhenStayCalled_ReturnsNoChangeInDoor()
        {
            //arrange
            var participant = new Participant(new RandomNum(), Strategy.Stay);
            var currentDoor = 0;
            var totalDoors = 3;
            //act
            var result = participant.SecondDoorStrategy(currentDoor, totalDoors);
            //assert
            Assert.Equal(currentDoor, result);
        }

        [Fact]
        public void SecondDoorStrategy_WhenSwitchCalled_ReturnsNegativeIndication()
        {
            //arrange
            var participant = new Participant(new RandomNum(), Strategy.Switch);
            var currentDoor = 1;
            var totalDoors = 3;
            //act
            var result = participant.SecondDoorStrategy(currentDoor, totalDoors);
            //assert
            Assert.Equal(-1, result);
            
        }
    }
}