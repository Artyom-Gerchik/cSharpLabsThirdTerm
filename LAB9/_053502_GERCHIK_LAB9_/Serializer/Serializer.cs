using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;
using Domain;

namespace Serializer
{
    public class Serializer : ISerializer
    {
        public IEnumerable<RailwayStation> DeSerializeByLINQ(string fileName)
        {
            var xDoc = XDocument.Load(fileName);

            var obj = from xElement in xDoc.Element("RailwayStations")?.Elements("RailwayStation")
                select new RailwayStation()
                {
                    RailwayStationName = xElement.Element("Name")?.Value,
                    RailwayStationCountOfWays = Convert.ToInt32(xElement.Element("CountOfWays")?.Value),
                    RailwayStationCountOfLuggageRooms =
                        Convert.ToInt32(xElement.Element("CountOfLuggageRooms")?.Value),

                    LuggageRooms = (from element in xElement.Elements("LuggageRoom")
                        select new LuggageRoom()
                        {
                            _luggageRoomHeight =
                                Convert.ToInt32(element.Element("RoomHeight")?.Value),
                            _luggageRoomWidth =
                                Convert.ToInt32(element.Element("RoomWidth")?.Value),
                            _luggageRoomDepth =
                                Convert.ToInt32(element.Element("RoomDepth")?.Value),
                        }).ToList()
                };
            return obj;
        }

        public IEnumerable<RailwayStation> DeSerializeXML(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<RailwayStation>));
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                var obj = (List<RailwayStation>) xmlSerializer.Deserialize(fileStream);
                return obj;
            }
        }

        public IEnumerable<RailwayStation> DeSerializeJSON(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                var temp = new JsonSerializerOptions {IncludeFields = true};
                var obj = JsonSerializer.DeserializeAsync<List<RailwayStation>>(fileStream, temp).Result;
                return obj;
            }
        }

        public void SerializeByLINQ(IEnumerable<RailwayStation> stations, string fileName)
        {
            XDocument document = new XDocument();

            var root = new XElement("RailwayStations");

            foreach (var station in stations)
            {
                var stationNode = new XElement("RailwayStation", new[]
                {
                    new XElement("Name", station.RailwayStationName),
                    new XElement("CountOfWays", station.RailwayStationCountOfWays.ToString()),
                    new XElement("CountOfLuggageRooms",
                        station.RailwayStationCountOfLuggageRooms.ToString()),
                });
                foreach (var room in station.LuggageRooms)
                {
                    var roomNode = new XElement("LuggageRoom", new[]
                    {
                        new XElement("RoomHeight", room._luggageRoomHeight.ToString()),
                        new XElement("RoomWidth", room._luggageRoomWidth.ToString()),
                        new XElement("RoomDepth", room._luggageRoomDepth.ToString())
                    });
                    stationNode.Add(roomNode);
                }

                root.Add(stationNode);
            }

            document.Add(root);
            document.Save(fileName);
        }

        public void SerializeXML(IEnumerable<RailwayStation> stations, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<RailwayStation>));
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, stations.ToList());
            }
        }

        public void SerializeJSON(IEnumerable<RailwayStation> stations, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                var temp = new JsonSerializerOptions {IncludeFields = true};
                JsonSerializer.SerializeAsync<List<RailwayStation>>(fileStream, stations.ToList(), temp).Wait();
            }
        }
    }
}