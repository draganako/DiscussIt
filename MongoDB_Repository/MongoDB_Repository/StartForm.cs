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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter data into both fields!");
                return;
            }

            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                User adm = MongoMongo.GetUserByCredentials("admin", "admin");

                AdminSettings asi= new AdminSettings(adm);
                asi.Show();
            }
            else
            {
                User get = MongoMongo.GetUserByUname(textBox1.Text);

                if (get != null)
                {
                    User get2 = MongoMongo.GetUserByCredentials(textBox1.Text, textBox2.Text);

                    if (get2 != null)
                    {
                        UserProfilePage pp = new UserProfilePage(get2);
                        pp.Show();
                    }
                    else
                        MessageBox.Show("Wrong password entered!");
                }
                else
                    MessageBox.Show("User does not exist");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            User get = MongoMongo.GetUserByUname(textBox1.Text);

            if (get != null)
                MessageBox.Show("User already exists");
            else
                MongoMongo.AddUser(new User(textBox1.Text, textBox2.Text));

        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            MongoMongo.InsertTestData();
        }
    }
}
