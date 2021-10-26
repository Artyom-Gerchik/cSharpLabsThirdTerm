using System;
using System.Collections.Generic;

namespace Domain
{
    public class RailwayStation
    {
        public List<LuggageRoom> LuggageRooms = new List<LuggageRoom>();

        private string RailwayStationName { get; set; }
        private int RailwayStationCountOfWays { get; set; }

        private int RailwayStationCountOfLuggageRooms = 0;

        public RailwayStation(string name, int countOfWays)
        {
            this.RailwayStationName = name;
            this.RailwayStationCountOfWays = countOfWays;
        }

        public RailwayStation(string name, int countOfWays,int luggageRoomHeight, int luggageRoomWidth, int luggageRoomDepth)
        {
            this.RailwayStationName = name;
            this.RailwayStationCountOfWays = countOfWays;
            RailwayStationCountOfLuggageRooms++;
            LuggageRooms.Add(new LuggageRoom(luggageRoomHeight,luggageRoomWidth,luggageRoomDepth));
        }

        public RailwayStation()
        {
            
        }
    }
}