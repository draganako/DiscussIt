namespace MongoDB_Repository.Layouts
{
    partial class CommentLayout1
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
            this.tbxText = new System.Windows.Forms.TextBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbxReplyingTo = new System.Windows.Forms.TextBox();
            this.lblReplied = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblReplyNumber = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxText
            // 
            this.tbxText.Enabled = false;
            this.tbxText.Location = new System.Drawing.Point(16, 76);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(339, 74);
            this.tbxText.TabIndex = 0;
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(264, 190);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(91, 25);
            this.btnReply.TabIndex = 1;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 56);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 17);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User ...";
            // 
            // tbxReplyingTo
            // 
            this.tbxReplyingTo.Enabled = false;
            this.tbxReplyingTo.Location = new System.Drawing.Point(102, 18);
            this.tbxReplyingTo.Name = "tbxReplyingTo";
            this.tbxReplyingTo.Size = new System.Drawing.Size(100, 22);
            this.tbxReplyingTo.TabIndex = 3;
            // 
            // lblReplied
            // 
            this.lblReplied.AutoSize = true;
            this.lblReplied.Location = new System.Drawing.Point(13, 21);
            this.lblReplied.Name = "lblReplied";
            this.lblReplied.Size = new System.Drawing.Size(83, 17);
            this.lblReplied.TabIndex = 4;
            this.lblReplied.Text = "Replying to:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(13, 160);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(243, 17);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Commented on: 00/00/0000 00:00:00";
            // 
            // lblReplyNumber
            // 
            this.lblReplyNumber.AutoSize = true;
            this.lblReplyNumber.Location = new System.Drawing.Point(270, 56);
            this.lblReplyNumber.Name = "lblReplyNumber";
            this.lblReplyNumber.Size = new System.Drawing.Size(85, 17);
            this.lblReplyNumber.TabIndex = 6;
            this.lblReplyNumber.Text = "(Replies: ///)";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(111, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 25);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // CommentLayout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblReplyNumber);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblReplied);
            this.Controls.Add(this.tbxReplyingTo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.tbxText);
            this.Name = "CommentLayout1";
            this.Size = new System.Drawing.Size(373, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxReplyingTo;
        private System.Windows.Forms.Label lblReplied;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblReplyNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}
