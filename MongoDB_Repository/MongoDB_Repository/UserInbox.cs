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
    public partial class UserInbox : Form
    {
        User currentUser;
        public UserInbox()
        {
            InitializeComponent();
        }
        public UserInbox(User curr)
        {
            InitializeComponent();
            currentUser=curr;

            List<Comment> read = MongoMongo.GetAllUserReadComments(currentUser); 
            List<Comment> unread = MongoMongo.GetAllUserUnreadComments(currentUser);

            lbxReadComments.DataSource = read;
            lbxUnreadComments.DataSource = unread;
            currentUser.updateInbox = 0; 
            MongoMongo.ModifyUser(currentUser);

            foreach (Comment c in unread)
            {
                c.notRead = 0;
                MongoMongo.ModifyComment(c);
            }


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UserInbox_Load(object sender, EventArgs e)
        {
           
        }
    }
}
