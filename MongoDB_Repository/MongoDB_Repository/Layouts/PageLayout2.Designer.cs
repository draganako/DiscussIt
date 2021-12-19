namespace MongoDB_Repository.Layouts
{
    partial class PageLayout2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTopics = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.lbxTopics = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpData = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMyPosts = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPageNum = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Location = new System.Drawing.Point(21, 51);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(86, 17);
            this.lblTopics.TabIndex = 21;
            this.lblTopics.Text = "Topics I like:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 17);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "User: ...";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(352, 71);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(482, 177);
            this.tbxDescription.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(349, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description:";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(860, 209);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(221, 39);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify profile";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.Location = new System.Drawing.Point(24, 214);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(153, 34);
            this.btnAddTopic.TabIndex = 14;
            this.btnAddTopic.Text = "Add new topic";
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(860, 71);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(221, 132);
            this.btnInbox.TabIndex = 13;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // lbxTopics
            // 
            this.lbxTopics.FormattingEnabled = true;
            this.lbxTopics.ItemHeight = 16;
            this.lbxTopics.Location = new System.Drawing.Point(24, 71);
            this.lbxTopics.Name = "lbxTopics";
            this.lbxTopics.Size = new System.Drawing.Size(322, 132);
            this.lbxTopics.TabIndex = 12;
            this.lbxTopics.SelectedIndexChanged += new System.EventHandler(this.lbxTopics_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpData);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(24, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 470);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // flpData
            // 
            this.flpData.Location = new System.Drawing.Point(7, 86);
            this.flpData.Name = "flpData";
            this.flpData.Size = new System.Drawing.Size(1050, 370);
            this.flpData.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPageNum);
            this.groupBox1.Controls.Add(this.btnPrevPage);
            this.groupBox1.Controls.Add(this.btnNextPage);
            this.groupBox1.Controls.Add(this.btnMyPosts);
            this.groupBox1.Controls.Add(this.btnFeed);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 67);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btnMyPosts
            // 
            this.btnMyPosts.Location = new System.Drawing.Point(387, 14);
            this.btnMyPosts.Name = "btnMyPosts";
            this.btnMyPosts.Size = new System.Drawing.Size(178, 47);
            this.btnMyPosts.TabIndex = 2;
            this.btnMyPosts.Text = "My posts";
            this.btnMyPosts.UseVisualStyleBackColor = true;
            this.btnMyPosts.Click += new System.EventHandler(this.btnMyPosts_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(111, 14);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(178, 47);
            this.btnFeed.TabIndex = 1;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.Location = new System.Drawing.Point(919, 31);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(16, 17);
            this.lblPageNum.TabIndex = 8;
            this.lblPageNum.Text = "0";
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevPage.Location = new System.Drawing.Point(817, 16);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(80, 45);
            this.btnPrevPage.TabIndex = 7;
            this.btnPrevPage.Text = "Previous page";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(965, 16);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(80, 45);
            this.btnNextPage.TabIndex = 6;
            this.btnNextPage.Text = "Next page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // PageLayout2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTopics);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.lbxTopics);
            this.Name = "PageLayout2";
            this.Size = new System.Drawing.Size(1147, 800);
            this.Load += new System.EventHandler(this.PageLayout2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.ListBox lbxTopics;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMyPosts;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpData;
        private System.Windows.Forms.Label lblPageNum;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
    }
}
