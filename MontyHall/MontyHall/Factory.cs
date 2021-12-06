using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using MontyHall.Enums;
using MontyHall.Interfaces;

namespace MontyHall
{
    /*
     * This is the factory class where all new instances are created
     * dependencies all point here to a single class
     */
    public static class Factory
    {
        public static IGame CreateGameStay(IRandom rand, int totalDoors)
        {
            return new Game(CreateDoorsList(), rand, CreateParticipantStay(), totalDoors);
        }
        
        public static IGame CreateGameSwitch(IRandom rand, int totalDoors)
        {
            return new Game(CreateDoorsList(), rand, CreateParticipantSwitch(), totalDoors);
        }

        // public static ISimulator CreateSimulator(ISimulator sim)
        // {
        //     return sim;
        // }

        public static IResult CreateResult()
        {
            return new Result();
        }

        private static IParticipant CreateParticipantStay()
        {
            return new Participant(CreateRandom(), Strategy.Stay);
        }

        private static IParticipant CreateParticipantSwitch()
        {
            return new Participant(CreateRandom(), Strategy.Switch);
        }

        private static List<Door> CreateDoorsList()
        {
            return new List<Door>();
        }

        public static IRandom CreateRandom()
        {
            return new RandomNum();
        }

        public static Door CreateDoor()
        {
            return new Door();
        }
    }
}