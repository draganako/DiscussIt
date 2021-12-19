using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository
{
    public static class MongoMongo
    {
        #region User

        public static void AddUser(User newUser)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");
            collection.Insert(newUser);
        }

        public static List<User> GetAllUsers()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            MongoCursor<User> allUsers = collection.FindAll();

            return allUsers.ToList<User>();

        }

        public static User GetUser(ObjectId userId)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            var query = Query.EQ("_id", userId); //

            return collection.Find(query).FirstOrDefault();
        }

        public static User GetUserByUname(string username)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            var query = Query.EQ("username", username);

            return collection.Find(query).FirstOrDefault();
        }

        public static User GetUserByCredentials(string username, string password)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            var query = Query.And(Query.EQ("username", username), Query.EQ("password", password));

            return collection.Find(query).FirstOrDefault();
        }

        public static void ModifyUser(User updatedUser, List<Topic> newTopics = null)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            var query = Query.EQ("_id", updatedUser.id);
            var update = MongoDB.Driver.Builders.Update.Set("password", updatedUser.password)
                                                       .Set("updateInbox", updatedUser.updateInbox)
                                                       .Set("selectedPageLayout", updatedUser.selectedPageLayout)
                                                       .Set("selectedCommentLayout", updatedUser.selectedCommentLayout);

            collection.Update(query, update);

            if (updatedUser.description != null)
            {
                query = Query.EQ("_id", updatedUser.id);
                update = MongoDB.Driver.Builders.Update.Set("description", updatedUser.description);
                collection.Update(query, update);
            }
            else
            {
                collection.Save(updatedUser); 
            }

            if (newTopics != null)
            {
                updatedUser.topics = new List<MongoDBRef>();
                foreach (Topic t in newTopics)
                    updatedUser.topics.Add(new MongoDBRef("topics", t.id));
                collection.Save(updatedUser);
            }
        }

        public static void RemoveUser(ObjectId userId)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            var query = Query.EQ("_id", userId);

            collection.Remove(query);
        }

        public static User GetUserFromDBRef(MongoDBRef userRef)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            return db.FetchDBRefAs<User>(userRef);
        }

        #endregion

        #region Topic

        public static void AddTopic(Topic newTopic, User created)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var topicsCollection = db.GetCollection<Topic>("topics");
            var usersCollection = db.GetCollection<User>("users");

            topicsCollection.Insert(newTopic);

            newTopic.user = new MongoDBRef("users", created.id);
            created.topics.Add(new MongoDBRef("topics", newTopic.id));
            created.ranking++;

            topicsCollection.Save(newTopic);
            usersCollection.Save(created);
        }

        public static Topic GetTopic(ObjectId topicId)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Topic>("topics");

            var query = Query.EQ("_id", topicId); //

            return collection.Find(query).FirstOrDefault();
        }

        public static List<Topic> GetAllTopics()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Topic>("topics");

            MongoCursor<Topic> all = collection.FindAll();

            return all.ToList<Topic>();
        }

        public static List<Topic> GetAllTopicsCreatedorFavedByUser(User user)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Topic>("topics");
            var collectionUsers = db.GetCollection<User>("users");

            List<Topic> result = new List<Topic>();

            for (int i = 0; i < user.topics.Count; i++)
            {
                Topic topic = db.FetchDBRefAs<Topic>(user.topics[i]);
                if (topic == null) //ako je topic obrisan a zaostala je referenca
                {
                    user.topics.RemoveAt(i);
                    collectionUsers.Save(user);
                    i--;
                }
                else
                    result.Add(topic);
            }

            return result;
        }

        public static Topic GetTopicByName(string name)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Topic>("topics");

            var query = Query.EQ("name", name);


            return collection.Find(query).FirstOrDefault();
        }

        public static Topic GetTopicFromDBRef(MongoDBRef topicRef)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            return db.FetchDBRefAs<Topic>(topicRef);
        }

        public static void RemoveTopic(ObjectId topicId)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            //brisemo sve postove za topic:
            var collectionPosts = db.GetCollection<Post>("posts");
            var query2 = Query.EQ("topic.$id", topicId);

            List<Post> alltopicposts = GetAllTopicPosts(GetTopic(topicId));

            foreach (Post p in alltopicposts)
                RemovePost(p.id);
            
            //brisemo topic
            var collectionTopics = db.GetCollection<Topic>("topics");
            var query = Query.EQ("_id", topicId);
            collectionTopics.Remove(query);
        }

        #endregion

        #region Post

        public static void AddPostToTopic(Post newPost, Topic topic, User user)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var topicsCollection = db.GetCollection<Topic>("topics");
            var usersCollection = db.GetCollection<User>("users");
            var postsCollecion = db.GetCollection<Post>("posts");

            postsCollecion.Insert(newPost);

            newPost.user = new MongoDBRef("users", user.id);
            newPost.topic = new MongoDBRef("topics", topic.id);

            topic.posts.Add(new MongoDBRef("posts", newPost.id));
            user.posts.Add(new MongoDBRef("posts", newPost.id));
            user.ranking++;

            postsCollecion.Save(newPost);
            topicsCollection.Save(topic);
            usersCollection.Save(user);
        }

        public static List<Post> GetAllTopicPosts(Topic topic)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            var query = Query.EQ("topic.$id", topic.id);

            MongoCursor<Post> posts = collection.Find(query);

            return posts.ToList<Post>();
        }

        public static List<Post> GetAllTopicPosts(Topic topic, int pageNo, int postsPerPage)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            var query = Query.EQ("topic.$id", topic.id);

            MongoCursor<Post> posts = collection.Find(query).SetSortOrder(SortBy.Descending("timestamp"))
                .SetSkip(pageNo * postsPerPage).SetLimit(postsPerPage);

            return posts.ToList<Post>();
        }

        public static List<Post> GetAllUserPosts(User user)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            var query = Query.EQ("user.$id", user.id);

            MongoCursor<Post> posts = collection.Find(query);

            return posts.ToList<Post>();
        }

        public static List<Post> GetAllUserPostsPaged(User user, int pageNo, int perPage)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            var query = Query.EQ("user.$id", user.id);

            MongoCursor<Post> posts = collection.Find(query)
                .SetSkip(pageNo * perPage).SetLimit(perPage);

            return posts.ToList<Post>();
        }

        public static int GetTotalPostsCount(ObjectId topicId) //not used
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            var count = (from post in collection.AsQueryable<Post>()
                         where post.topic.Id == topicId//atrib. obj. iz obj. modela
                         select post).Count();

            return count;
        }

        public static List<Post> GetPostsUserIsFollowing(User user)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            List<Post> povr = new List<Post>();

            List<BsonValue> val = new List<BsonValue>();//trazi se za .In
            for (int i = 0; i < user.topics.Count; i++)
            {
                val.Add(user.topics[i].Id);//id tipa bson
            }

            var query = Query.In("topic.$id", val);
            MongoCursor<Post> posts = collection.Find(query).SetSortOrder(SortBy.Ascending("timestamp"));
            povr.AddRange(posts);

            return povr;
        }

        public static List<Post> GetPostsUserIsFollowingPaged(User user, int pageNo, int perPage)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");

            List<Post> povr = new List<Post>();

            List<BsonValue> val = new List<BsonValue>();
            for (int i = 0; i < user.topics.Count; i++)
            {
                val.Add(user.topics[i].Id);
            }

            var query = Query.In("topic.$id", val);
            MongoCursor<Post> posts = collection.Find(query).SetSortOrder(SortBy.Descending("timestamp"))
             .SetSkip(pageNo * perPage).SetLimit(perPage);
            povr.AddRange(posts);

            return povr.ToList<Post>();
        }

        public static Post GetPostFromDBRef(MongoDBRef postRef)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            return db.FetchDBRefAs<Post>(postRef);
        }

        public static void RemovePost(ObjectId postId)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var postscollection = db.GetCollection<Post>("posts");
            var commentscollection = db.GetCollection<Comment>("comments");

            var query = Query.EQ("_id", postId);
            postscollection.Remove(query);

            var query2 = Query.EQ("post.$id", postId);
            commentscollection.Remove(query2);
        }

        #endregion

        #region Comment

        public static void AddCommentToPost(Comment newComment, User user, User replyingTo, Post post)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var commentscollection = db.GetCollection<Comment>("comments");
            var usersCollection = db.GetCollection<User>("users");
            var postsCollecion = db.GetCollection<Post>("posts");

            commentscollection.Insert(newComment);

            newComment.user = new MongoDBRef("users", user.id);
            newComment.post = new MongoDBRef("posts", post.id);
            newComment.replyTo = new MongoDBRef("users", replyingTo.id);

            post.comments.Add(new MongoDBRef("comments", newComment.id));

            commentscollection.Save(newComment);
            postsCollecion.Save(post);

            user.ranking++;
            usersCollection.Save(user);

            if (user.id != replyingTo.id)
            {
                replyingTo.updateInbox = 1;
                usersCollection.Save(replyingTo);
            }

        }

        public static List<Comment> GetAllPostComments(Post post)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Comment>("comments");

            var query = Query.EQ("post.$id", post.id);

            MongoCursor<Comment> all = collection.Find(query).SetSortOrder(SortBy.Descending("timestamp")); 

            return all.ToList<Comment>();
        }

        public static List<Comment> GetAllPostComments(Post post, int pageNo, int commentsPerPage)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Comment>("comments");

            var query = Query.EQ("post.$id", post.id);

            MongoCursor<Comment> all = collection.Find(query).SetSortOrder(SortBy.Descending("timestamp")) 
                .SetSkip(pageNo * commentsPerPage).SetLimit(commentsPerPage);

            return all.ToList<Comment>();
        }

        public static int GetTotalCommentCount(ObjectId postId) //not used
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection("comments");

            var count = (from comment in collection.AsQueryable<Comment>()
                         where comment.post.Id == postId
                         select comment).Count();

            return count;
        }

        public static List<Comment> GetAllUserUnreadComments(User user)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Comment>("comments");

            var query = Query.And(Query.EQ("notRead", 1), Query.EQ("replyTo.$id", user.id)); //linq

            MongoCursor<Comment> all = collection.Find(query).SetSortOrder(SortBy.Descending("timestamp")); 

            return all.ToList<Comment>();


        }

        public static List<Comment> GetAllUserReadComments(User user)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Comment>("comments");

            var res = from comment in collection.AsQueryable<Comment>()
                      where comment.notRead == 0
                      where comment.replyTo.Id == user.id
                      orderby comment.timestamp descending
                      select comment;

            return res.ToList<Comment>();
        }
        
        public static void ModifyComment(Comment updatedComment)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Comment>("comments");

            var query = Query.EQ("_id", updatedComment.id);
            var update = MongoDB.Driver.Builders.Update.Set("text", updatedComment.text)
                                                       .Set("timestamp", updatedComment.timestamp)
                                                       .Set("notRead", updatedComment.notRead);

            collection.Update(query, update);
        }

        public static void RemoveComment(ObjectId commentId)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("comments");

            var query = Query.EQ("_id", commentId);

            collection.Remove(query);
        }

        #endregion

        #region Flairs

        public static List<TopicFlair> GetAllUserFlairs(User u)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<TopicFlair>("flairs");


            var query = Query.EQ("user.$id", u.id);

            MongoCursor<TopicFlair> all = collection.Find(query);

            return all.ToList<TopicFlair>();
        }

        public static List<TopicFlair> GetUserFlairTopic(User u, Topic t)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<TopicFlair>("flairs");

            var query = Query.And(Query.EQ("user.$id", u.id), Query.EQ("topic.$id", t.id));

            MongoCursor<TopicFlair> all = collection.Find(query);

            return all.ToList<TopicFlair>();

        }

        public static void AddFlairs(Topic topic, User created, TopicFlair newFlair)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var topicsCollection = db.GetCollection<Topic>("topics");
            var flairsCollection = db.GetCollection<TopicFlair>("flairs");
            var usersCollection = db.GetCollection<User>("users");

            flairsCollection.Insert(newFlair);

            newFlair.user = new MongoDBRef("users", created.id);
            newFlair.topic = new MongoDBRef("topics", topic.id);

            created.topicFlairs.Add(new MongoDBRef("flairs", newFlair.id));

            flairsCollection.Save(newFlair);
            usersCollection.Save(created);
        }

        public static void ModifyTopicFLair(TopicFlair updtopicf)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var tcollection = db.GetCollection<TopicFlair>("flairs");

            var query = Query.EQ("_id", updtopicf.id);



            var update = MongoDB.Driver.Builders.Update.Set("value", updtopicf.value);

            tcollection.Update(query, update);
        }

        #endregion

        #region DB

        public static void InsertTestData()
        {
            DeleteAllData();

            User useradmin = new User("admin", "admin");
            User user1 = new User("user1", "pass1");
            user1.selectedPageLayout = 3;
            user1.selectedCommentLayout = 1;
            user1.description = "Name: John;Age: 17";

            User user2 = new User("user2", "pass2");
            user2.selectedPageLayout = 3;
            user2.selectedCommentLayout = 3;
            user2.description = "Occupation: Teacher";

            User user3 = new User("user3", "pass3");
            user3.selectedPageLayout = 2;
            user3.selectedCommentLayout = 2;

            User user4 = new User("user4", "pass4");
            user4.selectedPageLayout = 1;
            user4.selectedCommentLayout = 4;

            AddUser(useradmin);
            AddUser(user1);
            AddUser(user2);
            AddUser(user3);
            AddUser(user4);

            Topic topic1 = new Topic("School", "Anything refering to school");
            Topic topic2 = new Topic("Food", "Favourites, least favourites, recipes etc");
            Topic topic3 = new Topic("Books", "For any bookworms out there");
            Topic topic4 = new Topic("Dogs", "Share your tips, stories and experiences");

            AddTopic(topic1, user1);
            AddTopic(topic2, user1);
            AddTopic(topic3, user2);
            AddTopic(topic4, user3);

            List<Topic> following1 = new List<Topic>();
            following1.Add(topic1);
            following1.Add(topic2);
            following1.Add(topic3);

            ModifyUser(user1, following1);
            ModifyUser(user4, following1);

            TopicFlair topicFlair1 = new TopicFlair();
            topicFlair1.value = "school_girl";
            AddFlairs(topic1, user1, topicFlair1);

            TopicFlair topicFlair2 = new TopicFlair();
            topicFlair2.value = "nerd";
            AddFlairs(topic1, user4, topicFlair2);

            Post post1 = new Post { title = "Notebooks", question = "What are your favourite notebook producers?" };
            post1.timestamp = DateTime.Now;
            AddPostToTopic(post1, topic1, user1);

            Post post2 = new Post { title = "Study tips", question = "Are there any good tips on studying?" };
            post2.timestamp = DateTime.Now;
            AddPostToTopic(post2, topic1, user4);

            Comment comment1 = new Comment();
            comment1.layout = user4.selectedCommentLayout;
            comment1.notRead = 1;
            comment1.isAReply = 0;
            comment1.text = "I kinda like Lastva";
            AddCommentToPost(comment1, user4, user1, post1);

            Comment comment2 = new Comment();
            comment2.layout = user1.selectedCommentLayout;
            comment2.notRead = 1;
            comment2.isAReply = 1;
            comment2.text = "And have you heard of aceco?";
            AddCommentToPost(comment2, user1, user4, post1);

        }

        public static void DeleteAllData()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collectionFlairs = db.GetCollection<Post>("flairs");
            collectionFlairs.RemoveAll();

            var collectionComments = db.GetCollection<Comment>("comments");
            collectionComments.RemoveAll();

            var collectionPosts = db.GetCollection<Post>("posts");
            collectionPosts.RemoveAll();

            var collectionTopics = db.GetCollection<Topic>("topics");
            collectionTopics.RemoveAll();

            var collectionUsers = db.GetCollection<User>("users");
            collectionUsers.RemoveAll();
        }

        #endregion
    }
}
