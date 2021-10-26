using System;
using System.Collections.Generic;
using Domain;

namespace Serializer
{
    public class Serializer:ISerializer
    {
        public IEnumerable<RailwayStation> DeSerializeByLINQ(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RailwayStation> DeSerializeXML(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RailwayStation> DeSerializeJSON(string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeByLINQ(IEnumerable<RailwayStation> xxx, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeXML(IEnumerable<RailwayStation> xxx, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeJSON(IEnumerable<RailwayStation> xxx, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}