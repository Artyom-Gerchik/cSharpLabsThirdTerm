using System;
using System.Collections.Generic;

namespace Domain
{
    [Serializable]
    public class RailwayStation
    {
        public List<LuggageRoom> LuggageRooms = new List<LuggageRoom>();

        public string RailwayStationName { get; set; }
        public int RailwayStationCountOfWays { get; set; }

        public int RailwayStationCountOfLuggageRooms = 0;

        public RailwayStation(string name, int countOfWays)
        {
            this.RailwayStationName = name;
            this.RailwayStationCountOfWays = countOfWays;
        }

        public RailwayStation(string name, int countOfWays, int luggageRoomHeight, int luggageRoomWidth,
            int luggageRoomDepth)
        {
            this.RailwayStationName = name;
            this.RailwayStationCountOfWays = countOfWays;
            this.RailwayStationCountOfLuggageRooms++;
            LuggageRooms.Add(new LuggageRoom(luggageRoomHeight, luggageRoomWidth, luggageRoomDepth));
        }

        public RailwayStation(string name, int countOfWays, List<LuggageRoom> listOfRooms)
        {
            this.RailwayStationName = name;
            this.RailwayStationCountOfWays = countOfWays;

            for (int index = 0; index < listOfRooms.Count; index++)
            {
                this.LuggageRooms.Add(listOfRooms[index]);
                this.RailwayStationCountOfLuggageRooms++;
            }
        }

        public RailwayStation()
        {
        }
    }
}