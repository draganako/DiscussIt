using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDB_Repository.Entities
{
    public class User
    {
        public ObjectId id { get; set; }

        public string username { get; set; }
        public string password { get; set; }

        public int ranking { get; set; }
        public int selectedPageLayout { get; set; }
        public int selectedCommentLayout { get; set; }
        public int updateInbox { get; set; }

        public string description;
        public List<MongoDBRef> topics { get; set; }

        public List<MongoDBRef> topicFlairs { get; set; }
        public List<MongoDBRef> posts { get; set; }

        public User()
        {
            topics = new List<MongoDBRef>();
            topicFlairs = new List<MongoDBRef>();
            posts = new List<MongoDBRef>();
            ranking = 0;
            selectedPageLayout = 1;
            selectedCommentLayout = 1;
        }

        public User(string un, string pass)
        {
            topics = new List<MongoDBRef>();
            topicFlairs = new List<MongoDBRef>();
            posts = new List<MongoDBRef>();
            username = un;
            password = pass;
            ranking = 0;
            selectedPageLayout = 1;
            selectedCommentLayout = 1;
        }

        public override string ToString()
        {
            return username;
        }
        public string CalculateRank()
        {
            if (ranking <= 500)
                return "silver member";
            else if(ranking<=1500)
                return "gold member";
            else
                return "platinum member";
            
        }
    }
}
