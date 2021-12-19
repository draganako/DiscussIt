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
    public partial class ModifyProfile : Form
    {
        List<string> descrLines = new List<string>();

        List<Topic> alltopics = new List<Topic>();
        List<Topic> alltopicsuserlikes = new List<Topic>();
        List<TopicFlair> userFlairs = new List<TopicFlair>();

        User currUser; 
        int selectedPageLayout;
        int selectedCommentLayout;

        public ModifyProfile()
        {
            InitializeComponent();
        }

        public ModifyProfile(User user)
        {
            InitializeComponent();

            currUser = user;
            selectedPageLayout = 0;
            selectedCommentLayout = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ChangeUserProfile();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rbnPageLayout1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton source = sender as RadioButton;
            if (source.Equals(rbnPageLayout1))
            {
                selectedPageLayout = 1;
            }
            else if (source.Equals(rbnPageLayout2))
            {
                selectedPageLayout = 2;
            }
            else
            {
                selectedPageLayout = 3;
            }
        }
        

        private void rbnCommentLayout1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton source = sender as RadioButton;
            if (source.Equals(rbnCommentLayout1))
            {
                selectedCommentLayout = 1;
            }
            else if (source.Equals(rbnCommentLayout2))
            {
                selectedCommentLayout = 2;
            }
            else if (source.Equals(rbnCommentLayout3))
            {
                selectedCommentLayout = 3;
            }
            else
            {
                selectedCommentLayout = 4;
            }
        }

        private void ChangeUserProfile()
        {
            if (selectedPageLayout > 1)
                currUser.selectedPageLayout = selectedPageLayout;
            if (selectedCommentLayout > 1)
                currUser.selectedCommentLayout = selectedCommentLayout;

            if (descrLines.Count > 0)
            {
                currUser.description = descrLines[0];

                foreach (string el in descrLines)
                {
                    if (descrLines.IndexOf(el) != 0)
                        currUser.description += ";" + el;
                }
            }
            else
            {
                currUser.description = null;
            }

            List<Topic> newChecked = new List<Topic>();

            foreach (int indexChecked in lbxTopics.CheckedIndices)
                newChecked.Add(lbxTopics.Items[indexChecked] as Topic);

            MongoMongo.ModifyUser(currUser, newChecked);
        }

        private void ModifyProfile_Load(object sender, EventArgs e)
        {
            SelectRbtnsOnLoad();
            AddInfoSectionFill();

            alltopics = MongoMongo.GetAllTopics();
            alltopicsuserlikes = MongoMongo.GetAllTopicsCreatedorFavedByUser(currUser);
            
            userFlairs = MongoMongo.GetAllUserFlairs(currUser);

            lbxTopics.Items.Clear();
            foreach (Topic t in alltopics)
            {
                Topic tt = (from topic in alltopicsuserlikes.AsQueryable<Topic>()
                           where topic.id == t.id
                           select topic).FirstOrDefault();

                if (tt != null)
                    lbxTopics.Items.Add(t, CheckState.Checked);
                else
                    lbxTopics.Items.Add(t, CheckState.Unchecked);
            }
        }

        private void AddInfoSectionFill()
        {
            if (currUser.description != null)
            {
                string[] descStrings;
                descStrings = currUser.description.Split(';');
                descrLines = new List<string>();
                descrLines.AddRange(descStrings);
                lbxDescription.DataSource = descrLines;
            }
        }

        private void SelectRbtnsOnLoad()
        {
            int i = currUser.selectedPageLayout;
            if (i == 1)
                rbnPageLayout1.Checked = true;
            else if (i == 2)
                rbnPageLayout2.Checked = true;
            else
                rbnPageLayout3.Checked = true;

            i = currUser.selectedCommentLayout;
           
            if (i == 1)
                rbnCommentLayout1.Checked = true;
            else if (i == 2)
                rbnCommentLayout2.Checked = true;
            else if (i == 3)
                rbnCommentLayout3.Checked = true;
            else
                rbnCommentLayout4.Checked = true;
        }


        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxName.Text) || string.IsNullOrEmpty(tbxValue.Text))
            {
                MessageBox.Show("Please enter data into both property fields!");
                return;
            }

            descrLines.Add(tbxName.Text + ": " + tbxValue.Text);
            lbxDescription.DataSource = null;
            lbxDescription.DataSource = descrLines;

            tbxName.Text = "";
            tbxValue.Text = "";
        }

        private void btnRemoveInfo_Click(object sender, EventArgs e)
        {
            descrLines.RemoveAt(lbxDescription.SelectedIndex);
            lbxDescription.DataSource = null;
            lbxDescription.DataSource = descrLines;
        }

        private void btnFlair_Click(object sender, EventArgs e)
        {
            TopicFlair ff = new TopicFlair();

            List<TopicFlair> f = MongoMongo.GetUserFlairTopic(currUser, alltopics[lbxTopics.SelectedIndex]);
            Topic changedT = MongoMongo.GetTopicByName(alltopics[lbxTopics.SelectedIndex].name);

            ff.value = tbxFlair.Text;

            if (f != null && f.Count > 0)
            {
                ff = f[0];
                ff.value = tbxFlair.Text;
                MongoMongo.ModifyTopicFLair(ff);
            }
            else
            {
                MongoMongo.AddFlairs(changedT, currUser, ff);
            }
            
            
           
        }

        private void lbxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            List< TopicFlair> f = MongoMongo.GetUserFlairTopic(currUser, alltopics[lbxTopics.SelectedIndex]);
            if(f != null && f.Count > 0)
            {
                tbxFlair.Text = f[0].value;
            }
            else
            {
                tbxFlair.Text = "";
            }
        }
    }
}
