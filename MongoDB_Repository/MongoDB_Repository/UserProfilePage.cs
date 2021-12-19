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
    public partial class UserProfilePage : Form
    {
        private User currentUser;
        private User displayedUser;
        private UserControl selectedPageLayout;

        public UserProfilePage()
        {
            InitializeComponent();
        }

        public UserProfilePage(User current)
        {
            InitializeComponent();

            currentUser = current;
            displayedUser = current;

        }


        public UserProfilePage(User current, User displayedUsr)
        {
            InitializeComponent();

            currentUser = current;
            displayedUser = displayedUsr;

        }

        private void SetUserPageLayout()
        {
            if (displayedUser.selectedPageLayout == 1)
            {
                selectedPageLayout = new PageLayout1(currentUser, displayedUser);
                selectedPageLayout.Parent = this;
                //this.Width = 1000;
                //this.Height = 750;
                selectedPageLayout.Show();
            }
            else if (displayedUser.selectedPageLayout == 2)
            {
                selectedPageLayout = new PageLayout2(currentUser, displayedUser);
                selectedPageLayout.Parent = this;
                //this.Width = 1000;
                //this.Height = 750;
                selectedPageLayout.Show();
            }
            else
            {
                selectedPageLayout = new PageLayout3(currentUser, displayedUser);
                selectedPageLayout.Parent = this;
                this.Width = 1000;
                this.Height = 500;
                selectedPageLayout.Show();
            }
        }

        private void UserProfilePage_Load(object sender, EventArgs e)
        {
            SetUserPageLayout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
