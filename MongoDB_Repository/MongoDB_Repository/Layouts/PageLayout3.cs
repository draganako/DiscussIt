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
    public partial class PageLayout3 : UserControl
    {
        private User currentUser;
        private User displayedUser;
        private Topic selected;
        private List<Topic> mt;

        private Color backclr;

        bool showFeed;



        int page = 0;
        int perPage = 2;

        public PageLayout3()
        {
            InitializeComponent();
        }

        public PageLayout3(User current)
        {
            InitializeComponent();

            showFeed = true;
            currentUser = current;
            displayedUser = current;

            backclr = btnModify.BackColor;

            FillTheForm(false);

            page = 0;
            // perPage = 2;
        }

        public PageLayout3(User current, User displayedUsr)
        {
            InitializeComponent();

            showFeed = true;
            currentUser = current;
            displayedUser = displayedUsr;
            FillTheForm(true);

            page = 0;
            //perPage = 2;

            if (currentUser != displayedUser)
            {
                showFeed = false;
                btnMyPosts.Visible = false;
                btnFeed.Visible = false;
                btnModify.Visible = false;
                btnInbox.Visible = false;
                btnAddTopic.Visible = false;
            }
        }
        private void FillTheForm(bool zaDruge)
        {
            this.lblUsername.Text = "User: " + displayedUser.username + ", " + displayedUser.CalculateRank();

            tbxDescription.Text = "";

            if (displayedUser.description != null)
            {
                List<string> descStrings = displayedUser.description.Split(';').ToList();

                foreach (var s in descStrings)
                    tbxDescription.Text += s + Environment.NewLine;
            }

            mt = MongoMongo.GetAllTopicsCreatedorFavedByUser(displayedUser);
            lbxTopics.DataSource = null;
            lbxTopics.DataSource = mt;

            if (mt.Count > 0)
                selected = mt[0];

            if (zaDruge)
            {
                UpdateDataSetPosts(false);
            }
            else
            {
                UpdateDataSetPosts(true);
            }

            if (currentUser.updateInbox == 1 && currentUser == displayedUser)
            {
                btnInbox.BackColor = Color.PaleVioletRed;
            }

        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyProfile forma = new ModifyProfile(currentUser);
            DialogResult res = forma.ShowDialog();

            if (res == DialogResult.OK)
            {
                FillTheForm(showFeed);
            }

        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            UserInbox forma = new UserInbox(currentUser);

            if (forma.ShowDialog() == DialogResult.OK)
                btnInbox.BackColor = backclr;
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            AddTopic forma = new AddTopic(currentUser);
            DialogResult res = forma.ShowDialog();

            if (res == DialogResult.OK)
            {
                FillTheForm(showFeed);
            }
        }

        private void lbxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTopics.SelectedIndex >= 0)
                selected = mt[lbxTopics.SelectedIndex];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (lbxTopics.SelectedIndex < 0)
                MessageBox.Show("Please select a topic first!");
            else
            {
                TopicFrontPage forma = new TopicFrontPage(selected, currentUser);
                DialogResult dr = forma.ShowDialog();
            }
        }

        private void PageLayout3_Load(object sender, EventArgs e)
        {
            btnPrevPage.Enabled = false;
            btnFeed.Enabled = false;
            FillTheForm(showFeed);


            btnFeed.BackColor = Color.WhiteSmoke;
            btnMyPosts.BackColor = Color.LightSlateGray;

            flpData.AutoScroll = true;
            flpData.FlowDirection = FlowDirection.TopDown;
            flpData.WrapContents = false;
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            page = 0;
            btnPrevPage.Enabled = false;
            if (!showFeed)
            {


                UpdateDataSetPosts(false);


                showFeed = true;
                btnFeed.BackColor = Color.WhiteSmoke;
                btnMyPosts.BackColor = Color.LightSlateGray;
                btnMyPosts.Enabled = true;
                btnFeed.Enabled = false;

            }
            lblPageNum.Text = page.ToString();
        }

        private void btnMyPosts_Click(object sender, EventArgs e)
        {
            page = 0;
            btnPrevPage.Enabled = false;
            if (showFeed)
            {

                UpdateDataSetPosts(true);

                showFeed = false;
                btnMyPosts.BackColor = Color.WhiteSmoke;
                btnFeed.BackColor = Color.LightSlateGray;
                btnMyPosts.Enabled = false;
                btnFeed.Enabled = true;
            }
            lblPageNum.Text = page.ToString();
        }

        private void UpdateDataSetPosts(bool justUsers)
        {
            List<Post> myPosts;
            if (justUsers)
            {
                //myPosts = MongoMongo.GetAllUserPosts(displayedUser);
                myPosts = MongoMongo.GetAllUserPostsPaged(displayedUser, page, perPage);
            }
            else
                //myPosts = MongoMongo.GetPostsUserIsFollowing(displayedUser);
                myPosts = MongoMongo.GetPostsUserIsFollowingPaged(displayedUser, page, perPage);

            flpData.Controls.Clear();
            foreach (Post p in myPosts)
            {
                PostLayout postLayout = new PostLayout(p, currentUser);
                flpData.Controls.Add(postLayout);
            }
        }


        private void btnPrevPage_Click(object sender, EventArgs e)
        {

            if (page != 0)
            {
                page -= 1;


                FillTheForm(showFeed);
            }

            if (page == 0)
                btnPrevPage.Enabled = false;

            lblPageNum.Text = page.ToString();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            page++;
            if (page > 0)
                btnPrevPage.Enabled = true;


            FillTheForm(showFeed);
            lblPageNum.Text = page.ToString();
        }
    }
}
