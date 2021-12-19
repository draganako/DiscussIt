namespace MongoDB_Repository.Layouts
{
    partial class PostLayout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblQuest = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.LlblUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(221, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title: ///";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(371, 129);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(90, 17);
            this.lblComments.TabIndex = 1;
            this.lblComments.Text = "Comments: //";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Enabled = false;
            this.tbxQuestion.Location = new System.Drawing.Point(16, 55);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(885, 54);
            this.tbxQuestion.TabIndex = 3;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(16, 120);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(215, 26);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Location = new System.Drawing.Point(13, 35);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(69, 17);
            this.lblQuest.TabIndex = 5;
            this.lblQuest.Text = "Question:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(677, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Posted on: //";
            // 
            // LlblUser
            // 
            this.LlblUser.AutoSize = true;
            this.LlblUser.Location = new System.Drawing.Point(617, 26);
            this.LlblUser.Name = "LlblUser";
            this.LlblUser.Size = new System.Drawing.Size(72, 17);
            this.LlblUser.TabIndex = 7;
            this.LlblUser.TabStop = true;
            this.LlblUser.Text = "linkLabel1";
            this.LlblUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PostLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LlblUser);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblTitle);
            this.Name = "PostLayout";
            this.Size = new System.Drawing.Size(921, 157);
            this.Load += new System.EventHandler(this.PostLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.LinkLabel LlblUser;
    }
}
