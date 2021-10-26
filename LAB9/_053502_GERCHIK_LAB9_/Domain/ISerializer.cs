using System.Collections.Generic;

namespace Domain
{
    public interface ISerializer
    {
        IEnumerable<RailwayStation> DeSerializeByLINQ(string fileName);
        IEnumerable<RailwayStation> DeSerializeXML(string fileName);
        IEnumerable<RailwayStation> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<RailwayStation> xxx, string fileName);
        void SerializeXML(IEnumerable<RailwayStation> xxx, string fileName);
        void SerializeJSON(IEnumerable<RailwayStation> xxx, string fileName); 
    }
}