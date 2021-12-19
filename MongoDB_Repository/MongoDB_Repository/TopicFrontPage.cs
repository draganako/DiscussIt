using MongoDB_Repository.Entities;
using MongoDB_Repository.Layouts;
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
    public partial class TopicFrontPage : Form
    {
        private Topic topic;
        private User currUser;

        private int pageNo;
        private int postsPerPage;

        public TopicFrontPage()
        {
            InitializeComponent();
        }

        public TopicFrontPage(Topic t,User cu)
        {
            InitializeComponent();

            this.topic = t;
            currUser = cu;

            pageNo = 0;
            postsPerPage = 10;

            FillTheForm();
        }

        private void FillTheForm()
        {
            lblName.Text = "Topic: " + topic.name;
            tbxDesc.Text = topic.description;
            lblUserCreated.Text = "(Created by: " + MongoMongo.GetUserFromDBRef(topic.user).username + ")";

            btnPrevPage.Enabled = false;

            LoadPostsList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            AddPost forma = new AddPost(topic, currUser);
            DialogResult dr = forma.ShowDialog();

            if (dr == DialogResult.OK)
            {
               
                LoadPostsList();
            }
        }

        private void LoadPostsList()
        {
            flpPosts.Controls.Clear();

            int totalPostCount = topic.posts.Count;

            List<Post> posts = MongoMongo.GetAllTopicPosts(topic, pageNo, postsPerPage);

            if ((posts.Count < postsPerPage) ||
                ((totalPostCount % postsPerPage == 0) && ((pageNo + 1) == totalPostCount / postsPerPage)))
                btnNextPage.Enabled = false;
            else
                btnNextPage.Enabled = true;

            foreach (Post p in posts)
            {
                PostLayout postLayout = new PostLayout(p, currUser);
                flpPosts.Controls.Add(postLayout);
            }

            lblPostsNumber.Text = "(" + totalPostCount + ")";
        }

        private void TopicFrontPage_Load(object sender, EventArgs e)
        {
            flpPosts.AutoScroll = true;
            flpPosts.FlowDirection = FlowDirection.TopDown;
            flpPosts.WrapContents = false;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNo == 0)
                btnPrevPage.Enabled = true;
            pageNo++;
            LoadPostsList();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            pageNo--;
            if (pageNo == 0)
                btnPrevPage.Enabled = false;
            LoadPostsList();
        }
    }
}
