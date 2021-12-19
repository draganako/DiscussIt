using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB_Repository.Entities;

namespace MongoDB_Repository.Layouts
{
    public partial class PostLayout : UserControl
    {
        Post post;
        private User currentUser;
        public static int noofcomm=0;
        User posting;
        private List<Comment> listcomm;

        public PostLayout()
        {
            InitializeComponent();
        }

        public PostLayout(Post post, User current)
        {
            InitializeComponent();
            currentUser = current;
            this.post = post;
            
            FillTheForm();
        }

        private void FillTheForm()
        {
            posting = MongoMongo.GetUserFromDBRef(post.user);

            lblTitle.Text = "Title: " + post.title + "  (Topic: " + MongoMongo.GetTopicFromDBRef(post.topic).name + ")";
            tbxQuestion.Text = post.question;
            LlblUser.Text = "(Posted by: " + posting + ")";

            List<TopicFlair> ff = MongoMongo.GetAllUserFlairs(posting);

            for(int i =0; i< ff.Count; i++)
            {
                if (ff[i].topic == post.topic)
                    LlblUser.Text += " -- \" " + ff[i].value + " \" ";
            }
            
            lblComments.Text = "Comments: " + post.comments.Count.ToString();
            lblDate.Text = "Posted on: " + post.timestamp.ToString("yyyy/MM/dd");
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            PostPage dlg = new PostPage(currentUser, post);
            dlg.FormClosed += Dlg_FormClosed;
            dlg.ShowDialog();
        }

        private void Dlg_FormClosed(object sender, FormClosedEventArgs e)
        {
            listcomm = MongoMongo.GetAllPostComments(post);
            lblComments.Text = "Comments: " + listcomm.Count.ToString();
        }

        private void PostLayout_Load(object sender, EventArgs e)
        {
            listcomm = MongoMongo.GetAllPostComments(post);
            lblComments.Text = "Comments: " + listcomm.Count.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserProfilePage forma = new UserProfilePage(currentUser, posting);
            
            forma.ShowDialog();
        }
    }
}
