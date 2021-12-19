using MongoDB.Driver;
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
    public partial class PostPage : Form
    {
        private int pageNo; 
        private int commentsPerPage;
        private User currentUser; 
        private Post currentPost;
        
        private User replyingToUser;

        private bool edit;
        private Comment commentToUpdate;

        public PostPage()
        {
            InitializeComponent();
        }

        public PostPage(User current, Post post)
        {
            InitializeComponent();

            currentUser = current;
            currentPost = post;

            pageNo = 0; 
            commentsPerPage = 2; 

            FillTheForm();
        }

        private void FillTheForm()
        {
            lblTitle.Text = "Title: " + currentPost.title;
            lblPostedBy.Text = "Posted by: " + MongoMongo.GetUserFromDBRef(currentPost.user)+ ", " + currentUser.CalculateRank();
            
            tbxQuestion.Text = currentPost.question;
            btnCancel.Visible = false;
            edit = false;

            btnPrevPage.Enabled = false;

            LoadPostComments();
        }

        private void LoadPostComments()
        {
            flpComments.Controls.Clear();

            int totalCommentCount = currentPost.comments.Count;

            List<Comment> comments = MongoMongo.GetAllPostComments(currentPost, pageNo, commentsPerPage);

            if ((comments.Count < commentsPerPage) ||
                ((totalCommentCount % commentsPerPage == 0) && ((pageNo + 1) == totalCommentCount / commentsPerPage)))
                btnNextPage.Enabled = false;
            else
                btnNextPage.Enabled = true;


            foreach (Comment c in comments)
            {
                CommentLayout1 commentLayout = new CommentLayout1(c, currentUser);
                commentLayout.AddParentForm(this);
                flpComments.Controls.Add(commentLayout);
            }
            

            lblComments.Text = "Comments(" + totalCommentCount + "):";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxComment.Text))
            {
                MessageBox.Show("Your comment needs some words!!");
                return;
            }

            if (edit)
            {
                commentToUpdate.text = tbxComment.Text;
                commentToUpdate.timestamp = DateTime.Now;
                MongoMongo.ModifyComment(commentToUpdate);

                edit = false;
                commentToUpdate = null;
                tbxComment.Text = "";
                tbxReply.Text = "";
                btnAddComment.Text = "Add";
                btnCancel.Visible = false;

                LoadPostComments();
                return;
            }

            Comment newComment = new Comment();
            newComment.text = tbxComment.Text;
            newComment.layout = currentUser.selectedCommentLayout;
            newComment.notRead = 1;
            newComment.timestamp = DateTime.Now; 

            if (replyingToUser == null)
            {
                replyingToUser = MongoMongo.GetUserFromDBRef(currentPost.user);
                newComment.isAReply = 0;
            }
            else
                newComment.isAReply = 1;

            if (currentUser.id == replyingToUser.id)
                newComment.notRead = 0;

            MongoMongo.AddCommentToPost(newComment, currentUser, replyingToUser, currentPost);
            
            replyingToUser = null;
            tbxReply.Text = "";
            tbxComment.Text = "";

            pageNo = 0;
            btnPrevPage.Enabled = false; 
            LoadPostComments();
            
        }

        private void btnRemoveReply_Click(object sender, EventArgs e)
        {
            tbxReply.Text = "";
            replyingToUser = null;
        }

        public void AddReplyUser(User commentUser)
        {
            replyingToUser = commentUser;
            tbxReply.Text = "@" + replyingToUser.username;
        }

        public void DeleteComment(Comment commentToDelete)
        {
            MongoMongo.RemoveComment(commentToDelete.id);
            LoadPostComments();
            //SMANJITI U TREN. POSTU BR. KOM. pre loada
            //lblComments.Text= "Comments(" + currentPost.comments.Count + "):";
        }

        public void EditComment(Comment commentToEdit)
        {
            tbxComment.Text = commentToEdit.text;
            btnCancel.Visible = true;
            edit = true;
            commentToUpdate = commentToEdit;
            btnAddComment.Text = "Edit";
            if (commentToEdit.isAReply == 1)
                tbxReply.Text = "@" + MongoMongo.GetUserFromDBRef(commentToEdit.replyTo).username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            edit = false;
            commentToUpdate = null;
            tbxComment.Text = "";
            tbxReply.Text = "";
            btnAddComment.Text = "Add";
            btnCancel.Visible = false;
        }

        private void PostPage_Load(object sender, EventArgs e)
        {
            flpComments.AutoScroll = true;
            flpComments.FlowDirection = FlowDirection.TopDown;
            flpComments.WrapContents = false; 
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNo == 0)
                btnPrevPage.Enabled = true;
            pageNo++;
            LoadPostComments();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            pageNo--;
            if (pageNo == 0)
                btnPrevPage.Enabled = false;
            LoadPostComments();
        }
    }
}
