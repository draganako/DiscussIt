namespace MongoDB_Repository
{
    partial class TopicFrontPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.lblUserCreated = new System.Windows.Forms.Label();
            this.flpPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPostsNumber = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(110, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Topic: ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posts:";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Enabled = false;
            this.tbxDesc.Location = new System.Drawing.Point(113, 75);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(1074, 88);
            this.tbxDesc.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1001, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(809, 556);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(186, 37);
            this.btnAddPost.TabIndex = 7;
            this.btnAddPost.Text = "Add new post";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // lblUserCreated
            // 
            this.lblUserCreated.AutoSize = true;
            this.lblUserCreated.Location = new System.Drawing.Point(1080, 19);
            this.lblUserCreated.Name = "lblUserCreated";
            this.lblUserCreated.Size = new System.Drawing.Size(107, 17);
            this.lblUserCreated.TabIndex = 8;
            this.lblUserCreated.Text = "(Created by: ...)";
            // 
            // flpPosts
            // 
            this.flpPosts.Location = new System.Drawing.Point(113, 203);
            this.flpPosts.Name = "flpPosts";
            this.flpPosts.Size = new System.Drawing.Size(1074, 336);
            this.flpPosts.TabIndex = 9;
            // 
            // lblPostsNumber
            // 
            this.lblPostsNumber.AutoSize = true;
            this.lblPostsNumber.Location = new System.Drawing.Point(1145, 174);
            this.lblPostsNumber.Name = "lblPostsNumber";
            this.lblPostsNumber.Size = new System.Drawing.Size(42, 17);
            this.lblPostsNumber.TabIndex = 10;
            this.lblPostsNumber.Text = "(123)";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(1212, 508);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(76, 31);
            this.btnNextPage.TabIndex = 23;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(21, 508);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(76, 31);
            this.btnPrevPage.TabIndex = 22;
            this.btnPrevPage.Text = "Prev";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // TopicFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 607);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.lblPostsNumber);
            this.Controls.Add(this.flpPosts);
            this.Controls.Add(this.lblUserCreated);
            this.Controls.Add(this.btnAddPost);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "TopicFrontPage";
            this.Text = "TopicFrontPage";
            this.Load += new System.EventHandler(this.TopicFrontPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Label lblUserCreated;
        private System.Windows.Forms.FlowLayoutPanel flpPosts;
        private System.Windows.Forms.Label lblPostsNumber;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
    }
}