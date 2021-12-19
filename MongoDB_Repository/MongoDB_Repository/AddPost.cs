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
    public partial class AddPost : Form
    {
        Topic topic;
        User currUser;

        public AddPost()
        {
            InitializeComponent();
        }
        public AddPost(Topic t, User u)
        {
            this.topic = t;
            currUser = u;

            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Post p = new Post();

            if (string.IsNullOrEmpty(tbxTitle.Text) || string.IsNullOrEmpty(tbxQuestion.Text))
            {
                MessageBox.Show("Not enough information entered!");
                return;
            }
            else
            {
                p.title = tbxTitle.Text;
                p.question = tbxQuestion.Text;
                p.timestamp = DateTime.Now;

                MongoMongo.AddPostToTopic(p, topic, currUser);
               
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
