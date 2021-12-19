namespace MongoDB_Repository
{
    partial class UserInbox
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxUnreadComments = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxReadComments = new System.Windows.Forms.ListBox();
            this.lblArchived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New replies to your comments:";
            // 
            // lbxUnreadComments
            // 
            this.lbxUnreadComments.FormattingEnabled = true;
            this.lbxUnreadComments.ItemHeight = 16;
            this.lbxUnreadComments.Location = new System.Drawing.Point(24, 40);
            this.lbxUnreadComments.Name = "lbxUnreadComments";
            this.lbxUnreadComments.Size = new System.Drawing.Size(554, 164);
            this.lbxUnreadComments.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(459, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxReadComments
            // 
            this.lbxReadComments.FormattingEnabled = true;
            this.lbxReadComments.ItemHeight = 16;
            this.lbxReadComments.Location = new System.Drawing.Point(24, 229);
            this.lbxReadComments.Name = "lbxReadComments";
            this.lbxReadComments.Size = new System.Drawing.Size(554, 148);
            this.lbxReadComments.TabIndex = 3;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Location = new System.Drawing.Point(21, 209);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(67, 17);
            this.lblArchived.TabIndex = 4;
            this.lblArchived.Text = "Archived:";
            // 
            // UserInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.lblArchived);
            this.Controls.Add(this.lbxReadComments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbxUnreadComments);
            this.Controls.Add(this.label1);
            this.Name = "UserInbox";
            this.Text = "UserInbox";
            this.Load += new System.EventHandler(this.UserInbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxUnreadComments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxReadComments;
        private System.Windows.Forms.Label lblArchived;
    }
}