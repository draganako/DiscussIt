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
    public partial class CommentLayout1 : UserControl
    {
        private User currentUser;
        private User commentUser;
        private Comment currentComment;
        private PostPage parentForm; 

        public CommentLayout1()
        {
            InitializeComponent();
        }

        public CommentLayout1(Comment data, User current)
        {
            InitializeComponent();
            currentComment = data;
            currentUser = current;
            commentUser = MongoMongo.GetUserFromDBRef(currentComment.user);

            FillTheForm();
        }

        public void AddParentForm(PostPage parent)
        {
            this.parentForm = parent;
        }

        private void FillTheForm()
        {
            tbxText.Text = currentComment.text;

            if (currentComment.isAReply == 1)
            {
                tbxReplyingTo.Text = "@" + MongoMongo.GetUserFromDBRef(currentComment.replyTo).username;
            }
            else
            {
                tbxReplyingTo.Text = "";
            }
            
            if (currentUser.id == commentUser.id)
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }

            SetLayoutDesign();

            lblUser.Text = "User: " + commentUser.username;
            lblDateTime.Text = currentComment.timestamp.ToString("yyyy/MM/dd hh:mm:ss");
            lblReplyNumber.Text = "(Replies: " + currentComment.childComments.Count.ToString() + ")";

        }

        private void SetLayoutDesign()
        {
            switch(currentComment.layout)
            {
                case 1:SetDesign(System.Drawing.Color.AntiqueWhite,
                    System.Drawing.Color.LightSalmon, System.Drawing.Color.OrangeRed); break;//classic
                case 2:SetDesign(System.Drawing.Color.LightCyan,
                    System.Drawing.Color.LightSteelBlue, System.Drawing.Color.SteelBlue); break;//modern
                case 3:SetDesign(System.Drawing.Color.MistyRose, 
                    System.Drawing.Color.Pink, System.Drawing.Color.PaleVioletRed); break;//girly
                case 4:SetDesign(System.Drawing.Color.AliceBlue, 
                    System.Drawing.Color.LightBlue, System.Drawing.Color.DarkBlue); break;//traditional
            }
        }

        private void SetDesign(System.Drawing.Color col1, System.Drawing.Color col2, System.Drawing.Color col3)
        {
            this.BackColor = col1;
            tbxReplyingTo.BackColor=col1;
            tbxText.ForeColor=col1;

            btnEdit.BackColor = col2;
            btnReply.BackColor =col2;
            btnDelete.BackColor= col2;
        
            lblDateTime.ForeColor= col3;
            lblReplied.ForeColor = col3;
            lblReplyNumber.ForeColor=col3;
            lblUser.ForeColor = col3;

            btnDelete.ForeColor= col3;
            btnEdit.ForeColor = col3;
            btnReply.ForeColor= col3;

            tbxReplyingTo.ForeColor=col3;
            tbxText.ForeColor = col3;
        }
        
        private void btnReply_Click(object sender, EventArgs e)
        {
            parentForm.AddReplyUser(commentUser);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you wish to delete comment?",
                                                    "Delete comment?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                parentForm.DeleteComment(currentComment);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            parentForm.EditComment(currentComment);
        }
    }
}
