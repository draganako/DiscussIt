using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository.Entities
{
    public class TopicFlair
    {
        public ObjectId id { get; set; }

        public string value { get; set; }

        public MongoDBRef user { get; set; }

        public MongoDBRef topic { get; set; }

    }
}
