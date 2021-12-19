using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository.Entities
{
    public class Post
    {
        public ObjectId id { get; set; }
        public string title { get; set; }
        public string question { get; set; }

        public DateTime timestamp { get; set; }
        public MongoDBRef user { get; set; }
        public MongoDBRef topic { get; set; }

        public List<MongoDBRef> comments { get; set; }

        public Post()
        {
            comments = new List<MongoDBRef>();
        }

        public Post(string title, string question)
        {
            comments = new List<MongoDBRef>();
            this.title = title;
            this.question = question;
        }
    }
}
