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
    public partial class AddTopic : Form
    {
        private User currentUser;

        public AddTopic()
        {
            InitializeComponent();
        }

        public AddTopic(User current)
        {
            InitializeComponent();

            currentUser = current;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.name = tbxName.Text;
            topic.description = tbxDescription.Text;
            
            MongoMongo.AddTopic(topic, currentUser);

            MessageBox.Show("Topic added. Opening topic front page...");
            TopicFrontPage newTopic = new TopicFrontPage(topic,currentUser);
            DialogResult dr = newTopic.ShowDialog();
            if (dr == DialogResult.OK) 
            {
                DialogResult = DialogResult.OK;
                Close(); 
            }
        }
    }
}
