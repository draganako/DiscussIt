using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository.Entities
{
    public class Topic
    {
        public ObjectId id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public MongoDBRef user { get; set; }

        public List<MongoDBRef> posts { get; set; }

        public Topic()
        {
            posts = new List<MongoDBRef>();
        }

        public Topic(string name, string desc)
        {
            posts = new List<MongoDBRef>();
            this.name = name;
            this.description = desc;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
