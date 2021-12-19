namespace MongoDB_Repository
{
    partial class PostPage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPostedBy = new System.Windows.Forms.Label();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveReply = new System.Windows.Forms.Button();
            this.tbxReply = new System.Windows.Forms.TextBox();
            this.flpComments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(35, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 37);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close page";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Enabled = false;
            this.tbxQuestion.Location = new System.Drawing.Point(9, 111);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(358, 84);
            this.tbxQuestion.TabIndex = 10;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(407, 38);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(78, 17);
            this.lblComments.TabIndex = 9;
            this.lblComments.Text = "Comments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Question:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 17);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title: ...";
            // 
            // lblPostedBy
            // 
            this.lblPostedBy.AutoSize = true;
            this.lblPostedBy.Location = new System.Drawing.Point(6, 55);
            this.lblPostedBy.Name = "lblPostedBy";
            this.lblPostedBy.Size = new System.Drawing.Size(92, 17);
            this.lblPostedBy.TabIndex = 14;
            this.lblPostedBy.Text = "Posted By: ...";
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(9, 51);
            this.tbxComment.Multiline = true;
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.Size = new System.Drawing.Size(358, 85);
            this.tbxComment.TabIndex = 15;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(240, 142);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(127, 31);
            this.btnAddComment.TabIndex = 16;
            this.btnAddComment.Text = "Add";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRemoveReply);
            this.groupBox1.Controls.Add(this.tbxReply);
            this.groupBox1.Controls.Add(this.btnAddComment);
            this.groupBox1.Controls.Add(this.tbxComment);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 179);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add comment:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 31);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Replying to:";
            // 
            // btnRemoveReply
            // 
            this.btnRemoveReply.Location = new System.Drawing.Point(221, 24);
            this.btnRemoveReply.Name = "btnRemoveReply";
            this.btnRemoveReply.Size = new System.Drawing.Size(108, 24);
            this.btnRemoveReply.TabIndex = 21;
            this.btnRemoveReply.Text = "<-- Remove";
            this.btnRemoveReply.UseVisualStyleBackColor = true;
            this.btnRemoveReply.Click += new System.EventHandler(this.btnRemoveReply_Click);
            // 
            // tbxReply
            // 
            this.tbxReply.Enabled = false;
            this.tbxReply.Location = new System.Drawing.Point(95, 25);
            this.tbxReply.Name = "tbxReply";
            this.tbxReply.Size = new System.Drawing.Size(120, 22);
            this.tbxReply.TabIndex = 20;
            // 
            // flpComments
            // 
            this.flpComments.Location = new System.Drawing.Point(410, 76);
            this.flpComments.Name = "flpComments";
            this.flpComments.Size = new System.Drawing.Size(410, 498);
            this.flpComments.TabIndex = 19;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(637, 36);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(81, 31);
            this.btnPrevPage.TabIndex = 20;
            this.btnPrevPage.Text = "Prev";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(738, 36);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(82, 31);
            this.btnNextPage.TabIndex = 21;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPostedBy);
            this.groupBox2.Controls.Add(this.tbxQuestion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 211);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post info:";
            // 
            // PostPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.flpComments);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblComments);
            this.Name = "PostPage";
            this.Text = "PostPage";
            this.Load += new System.EventHandler(this.PostPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPostedBy;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpComments;
        private System.Windows.Forms.Button btnRemoveReply;
        private System.Windows.Forms.TextBox tbxReply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}