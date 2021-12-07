using System.Collections.Generic;
using Autofac.Extras.Moq;
using MontyHall.Interfaces;
using Moq;
using Xunit;

namespace MontyHall.Tests
{
    public class GameSetUpTests
    {
        // private IGame newGame;
        // public GameSetUpTests()
        // {
        //     newGame = Factory.CreateGameStay(new MockRandom(), 3);
        // }
        // [Fact]
        // public void CreateDoors_WhenGameStarts_ThenThreeDoorsAreCreated()
        // {
        //     //arrange
        //     //act
        //     newGame.CreateDoors();
        //     var result = newGame.GetDoors().Count;
        //     //assert
        //     Assert.Equal(3, result);
        // }
        //
        // [Fact]
        // public void CreateDoors_WhenGameStarts_ThenHaveAllDoorsClosed()
        // {
        //     //arrange
        //     //act
        //     newGame.CreateDoors();
        //     //assert
        //     foreach (var door in newGame.GetDoors())
        //     {
        //         Assert.False(door.IsOpen);
        //     }
        // }
        //
        // [Fact]
        // public void RandomisePrizePos_WhenRandomised_ThenOnlyOneDoorHasPrize()
        // {
        //     //arrange
        //     newGame.CreateDoors();
        //     //act
        //     newGame.RandomisePrizePos();
        //     //assert
        //     Assert.Single(newGame.GetDoors(), door => door.HasPrize);
        // }
        //
        // [Fact]
        // public void GetFirstDoorToPick_WhenCalled_ThenOnlyOneDoorIsPicked()
        // {
        //     //arrange
        //     newGame.CreateDoors();
        //     newGame.RandomisePrizePos();
        //     //act
        //     newGame.GetFirstDoor();
        //     //assert
        //     Assert.Single(newGame.GetDoors(), door => door.IsPicked);
        // }
        //
        // [Fact]
        // public void ShowDoor_WhenCalled_ThenDoorShownIsNotPickedAndHasNoPrize()
        // {
        //     //arrange
        //     var game = Factory.CreateGameStay(new MockRandom(), 3);
        //     game.CreateDoors();
        //     game.RandomisePrizePos();
        //     game.GetFirstDoor();
        //     //act
        //     game.ShowDoor();
        //     var door = game.GetDoors()[0];
        //     //assert
        //     Assert.Single(game.GetDoors(), d => d.IsOpen);
        //     Assert.False(door.IsPicked);
        //     Assert.False(door.HasPrize);
        // }
        //
        // [Fact]
        // public void GetSecondDoor_WhenCalledWithStay_ThenNoExtraDoorsPicked()
        // {
        //     //arrange
        //     newGame.CreateDoors();
        //     newGame.RandomisePrizePos();
        //     newGame.GetFirstDoor();
        //     newGame.ShowDoor();
        //     //act
        //     newGame.GetSecondDoor();
        //     //assert
        //     Assert.Single(newGame.GetDoors(), d => d.IsPicked);
        //
        // }
        //
        // [Fact]
        // public void GetSecondDoor_WhenCalledWithSwitch_ThenFirstPickedDoorNotOpen()
        // {
        //     //arrange
        //     var game = Factory.CreateGameSwitch(new MockRandom(), 3);
        //     game.CreateDoors();
        //     game.RandomisePrizePos();
        //     game.GetFirstDoor();
        //     game.ShowDoor();
        //     //act
        //     game.GetSecondDoor();
        //     //assert
        //     Assert.False(game.GetDoors()[game.GetFirstDoorIndex()].IsOpen);
        // }

        [Fact]
        public void RunGame_WhenCalled_ThenDoorsArePrinted()
        {
            var game = Factory.CreateGameStay(new RandomNum(), 3);
            game.RunGame();
        }
    }
}

