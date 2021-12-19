using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB_Repository.Entities;

namespace MongoDB_Repository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {

           

          

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<Post>("posts");
            collection.RemoveAll();

            var collection4 = db.GetCollection<Post>("flairs");
            collection4.RemoveAll();

            var collectionTopics = db.GetCollection<Topic>("topics");
            collectionTopics.RemoveAll();

            var collectionU = db.GetCollection<User>("users");
            collectionU.RemoveAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            MongoMongo.InsertTestData();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            StartForm forma = new StartForm();
            forma.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User testUser = new User { username = "a", password = "a" , selectedPageLayout = 3};
            MongoMongo.AddUser(testUser);
            User testUser2 = new User { username = "b", password = "b", selectedPageLayout = 1 };
            MongoMongo.AddUser(testUser2);

            User user1 = new User { username = "Petar", password = "Peraaa" };
            User user2 = new User { username = "Sava", password = "JnkSva" };
            User user3 = new User { username = "Milutin", password = "Sima123" };
            User user4 = new User { username = "Jelena", password = "jeJeJa", };
            User user5 = new User { username = "Mirjana", password = "mimi39" };

            MongoMongo.AddUser(user1);
            MongoMongo.AddUser(user2);
            MongoMongo.AddUser(user3);
            MongoMongo.AddUser(user4);
            MongoMongo.AddUser(user5);

        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("mongoo");

            var collection = db.GetCollection<User>("users");

            List<User> allUsers = collection.FindAll().SetLimit(1).ToList(); //probni user

            ObjectId userId = allUsers.ElementAt(0).id; 
            MongoMongo.GetUser(userId);
        }

        private void btnGetAllUsers_Click(object sender, EventArgs e)
        {
            MongoMongo.GetAllUsers();
        }

        private void btnTryLogin_Click(object sender, EventArgs e)
        {
            User get = MongoMongo.GetUserByCredentials("a", "a");

            if (get != null)
                MessageBox.Show(get.username);
            else
                MessageBox.Show("User does not exist");

            User get2 = MongoMongo.GetUserByCredentials("a", "b"); //ovaj ne postoji - vraca null

            if (get2 != null)
                MessageBox.Show(get.username);
            else
                MessageBox.Show("User does not exist");

        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            User myUser = MongoMongo.GetUserByCredentials("a", "a");
            myUser.password = "abc";
            MongoMongo.ModifyUser(myUser);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User testUser = new User { username = "test", password = "test" };
            MongoMongo.AddUser(testUser);

            MongoMongo.RemoveUser(testUser.id);

            MongoMongo.GetAllUsers();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            User test = MongoMongo.GetUserByCredentials("b", "b"); //korisnik koji dodaje topic
            Topic top = new Topic { name = "School" };

            MongoMongo.AddTopic(top, test);

            User test2 = MongoMongo.GetUserByCredentials("a", "a"); 
            Topic top2 = new Topic { name = "Food", description = "All things related to food" };

            MongoMongo.AddTopic(top2, test2);
        }

        private void btnGetTopic_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGetTopics_Click(object sender, EventArgs e)
        {
            MongoMongo.GetAllTopics();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            Topic t = MongoMongo.GetTopicByName("School");
            User posting = MongoMongo.GetUserByCredentials("b", "b");
            Post p = new Post { title = "Notebooks", question = "What are your favourite notebook producers?" };
            p.timestamp = DateTime.Now;
            MongoMongo.AddPostToTopic(p, t, posting);

            Post p2 = new Post { title = "Study tips", question = "Are there any good tips on studying?" };
            p2.timestamp = DateTime.Now;
            MongoMongo.AddPostToTopic(p2, t, posting);

            

            Post p3 = new Post { title = "School uniforms", question = "Yes or no?" };
            p3.timestamp = DateTime.Now;
            MongoMongo.AddPostToTopic(p3, t, posting);



            posting = MongoMongo.GetUserByCredentials("a", "a");
            p = new Post { title = "Notebooks help", question = "Does it work?" };
            p.timestamp = DateTime.Now;
            MongoMongo.AddPostToTopic(p, t, posting);
        }

        private void btnGetTopicPosts_Click(object sender, EventArgs e)
        {
            Topic t = MongoMongo.GetTopicByName("School");
            MongoMongo.GetAllTopicPosts(t);
        }

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            User test = MongoMongo.GetUserByCredentials("b", "b");
            User posting = MongoMongo.GetUserByCredentials("a", "a");
            // UserProfileDisplay forma = new UserProfileDisplay(test, posting);

            UserProfilePage forma = new UserProfilePage(test, posting);
            forma.ShowDialog();
        }
    }
}
