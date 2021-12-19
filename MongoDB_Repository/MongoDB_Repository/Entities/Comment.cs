using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_Repository.Entities
{
    public class Comment
    {
        public ObjectId id { get; set; }
        public string text { get; set; }
        public int layout { get; set; }
        public int notRead { get; set; }
        public int isAReply { get; set; }
        public DateTime timestamp { get; set; }
        public MongoDBRef user { get; set; }
        public MongoDBRef replyTo { get; set; }
        public MongoDBRef post { get; set; }

        public List<MongoDBRef> childComments { get; set; }

        public Comment()
        {
            childComments = new List<MongoDBRef>();
        }

        public override string ToString()
        {
            return "User " + MongoMongo.GetUserFromDBRef(user).username +
                " says: " + text + " on " + MongoMongo.GetPostFromDBRef(post).title;
        }
    }
}
