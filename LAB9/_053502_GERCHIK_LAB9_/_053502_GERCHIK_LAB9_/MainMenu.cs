using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace _053502_GERCHIK_LAB9_
{
    public class MainMenu
    {
        public void mainMenu()
        {
            const string linqToXmlPath =
                "/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB9/_053502_GERCHIK_LAB9_/LinqToXml.xml";
            const string xmlPath =
                "/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB9/_053502_GERCHIK_LAB9_/xml.xml";
            const string jsonPath =
                "/Users/lnxd/Desktop/BSUIR/THIRD TERM/ISP/LABS/LAB9/_053502_GERCHIK_LAB9_/json.json";

            List<LuggageRoom> rooms1 = new List<LuggageRoom>();
            List<LuggageRoom> rooms2 = new List<LuggageRoom>();

            rooms1.Add(new LuggageRoom(10, 20, 30));
            rooms1.Add(new LuggageRoom(11, 21, 31));
            rooms1.Add(new LuggageRoom(1, 2, 3));
            
            rooms2.Add(new LuggageRoom(154, 256, 323));

            RailwayStation railwayStation1 = new RailwayStation("Verdansk", 10, rooms1);
            RailwayStation railwayStation2 = new RailwayStation("Osipovichi", 5, rooms2);

            List<RailwayStation> railwayStations = new List<RailwayStation>();

            railwayStations.Add(railwayStation1);
            railwayStations.Add(railwayStation2);

            Serializer.Serializer tools = new Serializer.Serializer();

            Console.WriteLine();
            Console.WriteLine("#########LINQ#########");

            tools.SerializeByLINQ(railwayStations, linqToXmlPath);
            var deSerializedByLINQ = tools.DeSerializeByLINQ(linqToXmlPath);
            var deSerializedByLINQList = deSerializedByLINQ.ToList();

             for (int i = 0; i < deSerializedByLINQList.Count; i++)
             {
                 Console.WriteLine();
                 Console.WriteLine($"Name: {deSerializedByLINQList[i].RailwayStationName}");
                 Console.WriteLine($"Count Of Ways: {deSerializedByLINQList[i].RailwayStationCountOfWays.ToString()}");
                 Console.WriteLine(
                     $"Count Of Luggage Rooms: {deSerializedByLINQList[i].RailwayStationCountOfLuggageRooms.ToString()}");
                 for (int j = 0; j < deSerializedByLINQList[i].LuggageRooms.Count; j++)
                 {
                     Console.WriteLine(
                         $"{(j + 1).ToString()} _luggageRoomHeight: {deSerializedByLINQList[i].LuggageRooms[j]._luggageRoomHeight.ToString()}");
                     Console.WriteLine(
                         $"{(j + 1).ToString()} _luggageRoomWidth: {deSerializedByLINQList[i].LuggageRooms[j]._luggageRoomWidth.ToString()}");
                     Console.WriteLine(
                         $"{(j + 1).ToString()} _luggageRoomDepth: {deSerializedByLINQList[i].LuggageRooms[j]._luggageRoomDepth.ToString()}");
                     Console.WriteLine();
                 }
             }

            Console.WriteLine("#########LINQ#########");

            Console.WriteLine();
            Console.WriteLine("#########XML#########");

            tools.SerializeXML(railwayStations, xmlPath);
            var deSerializedXml = tools.DeSerializeXML(xmlPath);
            var deSerializedXmlList = deSerializedXml.ToList();

            for (int i = 0; i < deSerializedXmlList.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {deSerializedXmlList[i].RailwayStationName}");
                Console.WriteLine($"Count Of Ways: {deSerializedXmlList[i].RailwayStationCountOfWays.ToString()}");
                Console.WriteLine(
                    $"Count Of Luggage Rooms: {deSerializedXmlList[i].RailwayStationCountOfLuggageRooms.ToString()}");
                for (int j = 0; j < deSerializedXmlList[i].LuggageRooms.Count; j++)
                {
                    Console.WriteLine(
                        $"{(j + 1).ToString()} _luggageRoomHeight: {deSerializedXmlList[i].LuggageRooms[j]._luggageRoomHeight.ToString()}");
                    Console.WriteLine(
                        $"{(j + 1).ToString()} _luggageRoomWidth: {deSerializedXmlList[i].LuggageRooms[j]._luggageRoomWidth.ToString()}");
                    Console.WriteLine(
                        $"{(j + 1).ToString()} _luggageRoomDepth: {deSerializedXmlList[i].LuggageRooms[j]._luggageRoomDepth.ToString()}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("#########XML#########");

            Console.WriteLine();
            Console.WriteLine("#########JSON#########");

            tools.SerializeJSON(railwayStations, jsonPath);
            var deSerializedJson = tools.DeSerializeJSON(jsonPath);
            var deSerializedJsonList = deSerializedJson.ToList();

            for (int i = 0; i < deSerializedJsonList.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {deSerializedJsonList[i].RailwayStationName}");
                Console.WriteLine($"Count Of Ways: {deSerializedJsonList[i].RailwayStationCountOfWays.ToString()}");
                Console.WriteLine(
                    $"Count Of Luggage Rooms: {deSerializedJsonList[i].RailwayStationCountOfLuggageRooms.ToString()}");
                for (int j = 0; j < deSerializedJsonList[i].LuggageRooms.Count; j++)
                {
                    Console.WriteLine(
                        $"{(j + 1).ToString()} _luggageRoomHeight: {deSerializedJsonList[i].LuggageRooms[j]._luggageRoomHeight.ToString()}");
                    Console.WriteLine(
                        $"{(j + 1).ToString()} _luggageRoomWidth: {deSerializedJsonList[i].LuggageRooms[j]._luggageRoomWidth.ToString()}");
                    Console.WriteLine(
                        $"{(j + 1).ToString()} _luggageRoomDepth: {deSerializedJsonList[i].LuggageRooms[j]._luggageRoomDepth.ToString()}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("#########JSON#########");
        }
    }
}