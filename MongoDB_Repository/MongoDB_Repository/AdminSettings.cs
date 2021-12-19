using MongoDB.Driver;
using MongoDB_Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MongoDB_Repository
{
    public partial class AdminSettings : Form
    {
        private User admin;

        List<User> listOfUsers=new List<User>();
        List<Topic> listOfTopics=new List<Topic>();
        
        public AdminSettings()
        {
            InitializeComponent();
        }

        public AdminSettings(User admin)
        {
            InitializeComponent();

            this.admin = admin;
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            listOfUsers= MongoMongo.GetAllUsers();
            listOfTopics = MongoMongo.GetAllTopics();
           
            listBox1.DataSource = listOfUsers;
            listBox2.DataSource = listOfTopics;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 1)
                MessageBox.Show("One indice must be chosen");
            else
            {
                User user = MongoMongo.GetUserByUname(listBox1.SelectedItems[0].ToString());
                MongoMongo.RemoveUser(user.id);
                
                UpdateUserList();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count != 1)
                MessageBox.Show("One indice must be chosen");
            else
            {
                Topic t = MongoMongo.GetTopicByName(listBox2.SelectedItems[0].ToString());
                MongoMongo.RemoveTopic(t.id);
              
                UpdateTopicList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Topic newTopic = GetTopicData();

            if (newTopic != null)
            {
                MongoMongo.AddTopic(newTopic, admin);
                UpdateTopicList();
            }

            tbxDesc.Text = "";
            tbxName.Text = "";
        }

        private Topic GetTopicData()
        {
            if (String.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Topic must have a name!");
                return null;
            }

            Topic ret = new Topic();

            ret.name = tbxName.Text;
            if (String.IsNullOrEmpty(tbxDesc.Text))
                ret.description = null;
            else
                ret.description = tbxDesc.Text;

            return ret;
        }

        private void UpdateTopicList()
        {
            listOfTopics = MongoMongo.GetAllTopics();
            listBox2.DataSource = null;
            listBox2.DataSource = listOfTopics;
        }

        private void UpdateUserList()
        {
            listOfUsers = MongoMongo.GetAllUsers();
            listBox1.DataSource = null;
            listBox1.DataSource = listOfUsers;
        }
    }
}
