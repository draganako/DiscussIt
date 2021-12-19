namespace MongoDB_Repository
{
    partial class ModifyProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPageLayout3 = new System.Windows.Forms.RadioButton();
            this.rbnPageLayout2 = new System.Windows.Forms.RadioButton();
            this.rbnPageLayout1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnCommentLayout4 = new System.Windows.Forms.RadioButton();
            this.rbnCommentLayout3 = new System.Windows.Forms.RadioButton();
            this.rbnCommentLayout2 = new System.Windows.Forms.RadioButton();
            this.rbnCommentLayout1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxFlair = new System.Windows.Forms.TextBox();
            this.btnFlair = new System.Windows.Forms.Button();
            this.lbxTopics = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnRemoveInfo = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbxDescription = new System.Windows.Forms.ListBox();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnPageLayout3);
            this.groupBox1.Controls.Add(this.rbnPageLayout2);
            this.groupBox1.Controls.Add(this.rbnPageLayout1);
            this.groupBox1.Location = new System.Drawing.Point(59, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose page layout:";
            // 
            // rbnPageLayout3
            // 
            this.rbnPageLayout3.AutoSize = true;
            this.rbnPageLayout3.Location = new System.Drawing.Point(366, 44);
            this.rbnPageLayout3.Name = "rbnPageLayout3";
            this.rbnPageLayout3.Size = new System.Drawing.Size(114, 21);
            this.rbnPageLayout3.TabIndex = 2;
            this.rbnPageLayout3.Text = "Messy pieces";
            this.rbnPageLayout3.UseVisualStyleBackColor = true;
            this.rbnPageLayout3.CheckedChanged += new System.EventHandler(this.rbnPageLayout1_CheckedChanged);
            // 
            // rbnPageLayout2
            // 
            this.rbnPageLayout2.AutoSize = true;
            this.rbnPageLayout2.Location = new System.Drawing.Point(185, 44);
            this.rbnPageLayout2.Name = "rbnPageLayout2";
            this.rbnPageLayout2.Size = new System.Drawing.Size(121, 21);
            this.rbnPageLayout2.TabIndex = 1;
            this.rbnPageLayout2.Text = "Modern blocks";
            this.rbnPageLayout2.UseVisualStyleBackColor = true;
            this.rbnPageLayout2.CheckedChanged += new System.EventHandler(this.rbnPageLayout1_CheckedChanged);
            // 
            // rbnPageLayout1
            // 
            this.rbnPageLayout1.AutoSize = true;
            this.rbnPageLayout1.Checked = true;
            this.rbnPageLayout1.Location = new System.Drawing.Point(17, 44);
            this.rbnPageLayout1.Name = "rbnPageLayout1";
            this.rbnPageLayout1.Size = new System.Drawing.Size(94, 21);
            this.rbnPageLayout1.TabIndex = 0;
            this.rbnPageLayout1.TabStop = true;
            this.rbnPageLayout1.Text = "Classic list";
            this.rbnPageLayout1.UseVisualStyleBackColor = true;
            this.rbnPageLayout1.CheckedChanged += new System.EventHandler(this.rbnPageLayout1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnCommentLayout4);
            this.groupBox2.Controls.Add(this.rbnCommentLayout3);
            this.groupBox2.Controls.Add(this.rbnCommentLayout2);
            this.groupBox2.Controls.Add(this.rbnCommentLayout1);
            this.groupBox2.Location = new System.Drawing.Point(59, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose comment layout:";
            // 
            // rbnCommentLayout4
            // 
            this.rbnCommentLayout4.AutoSize = true;
            this.rbnCommentLayout4.Location = new System.Drawing.Point(370, 51);
            this.rbnCommentLayout4.Name = "rbnCommentLayout4";
            this.rbnCommentLayout4.Size = new System.Drawing.Size(96, 21);
            this.rbnCommentLayout4.TabIndex = 3;
            this.rbnCommentLayout4.TabStop = true;
            this.rbnCommentLayout4.Text = "Traditional";
            this.rbnCommentLayout4.UseVisualStyleBackColor = true;
            this.rbnCommentLayout4.CheckedChanged += new System.EventHandler(this.rbnCommentLayout1_CheckedChanged);
            // 
            // rbnCommentLayout3
            // 
            this.rbnCommentLayout3.AutoSize = true;
            this.rbnCommentLayout3.Location = new System.Drawing.Point(274, 51);
            this.rbnCommentLayout3.Name = "rbnCommentLayout3";
            this.rbnCommentLayout3.Size = new System.Drawing.Size(58, 21);
            this.rbnCommentLayout3.TabIndex = 2;
            this.rbnCommentLayout3.Text = "Girly";
            this.rbnCommentLayout3.UseVisualStyleBackColor = true;
            this.rbnCommentLayout3.CheckedChanged += new System.EventHandler(this.rbnCommentLayout1_CheckedChanged);
            // 
            // rbnCommentLayout2
            // 
            this.rbnCommentLayout2.AutoSize = true;
            this.rbnCommentLayout2.Location = new System.Drawing.Point(150, 51);
            this.rbnCommentLayout2.Name = "rbnCommentLayout2";
            this.rbnCommentLayout2.Size = new System.Drawing.Size(77, 21);
            this.rbnCommentLayout2.TabIndex = 1;
            this.rbnCommentLayout2.Text = "Modern";
            this.rbnCommentLayout2.UseVisualStyleBackColor = true;
            this.rbnCommentLayout2.CheckedChanged += new System.EventHandler(this.rbnCommentLayout1_CheckedChanged);
            // 
            // rbnCommentLayout1
            // 
            this.rbnCommentLayout1.AutoSize = true;
            this.rbnCommentLayout1.Checked = true;
            this.rbnCommentLayout1.Location = new System.Drawing.Point(24, 51);
            this.rbnCommentLayout1.Name = "rbnCommentLayout1";
            this.rbnCommentLayout1.Size = new System.Drawing.Size(73, 21);
            this.rbnCommentLayout1.TabIndex = 0;
            this.rbnCommentLayout1.TabStop = true;
            this.rbnCommentLayout1.Text = "Classic";
            this.rbnCommentLayout1.UseVisualStyleBackColor = true;
            this.rbnCommentLayout1.CheckedChanged += new System.EventHandler(this.rbnCommentLayout1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxFlair);
            this.groupBox3.Controls.Add(this.btnFlair);
            this.groupBox3.Controls.Add(this.lbxTopics);
            this.groupBox3.Location = new System.Drawing.Point(43, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose topics you like:";
            // 
            // tbxFlair
            // 
            this.tbxFlair.Location = new System.Drawing.Point(16, 190);
            this.tbxFlair.Name = "tbxFlair";
            this.tbxFlair.Size = new System.Drawing.Size(100, 22);
            this.tbxFlair.TabIndex = 2;
            // 
            // btnFlair
            // 
            this.btnFlair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlair.Location = new System.Drawing.Point(134, 184);
            this.btnFlair.Name = "btnFlair";
            this.btnFlair.Size = new System.Drawing.Size(92, 32);
            this.btnFlair.TabIndex = 1;
            this.btnFlair.Text = "Flair selected";
            this.btnFlair.UseVisualStyleBackColor = true;
            this.btnFlair.Click += new System.EventHandler(this.btnFlair_Click);
            // 
            // lbxTopics
            // 
            this.lbxTopics.FormattingEnabled = true;
            this.lbxTopics.Location = new System.Drawing.Point(16, 21);
            this.lbxTopics.Name = "lbxTopics";
            this.lbxTopics.Size = new System.Drawing.Size(210, 157);
            this.lbxTopics.TabIndex = 0;
            this.lbxTopics.SelectedIndexChanged += new System.EventHandler(this.lbxTopics_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(97, 549);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(189, 43);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Accept changes";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(311, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(189, 43);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddInfo);
            this.groupBox4.Controls.Add(this.btnRemoveInfo);
            this.groupBox4.Controls.Add(this.lblValue);
            this.groupBox4.Controls.Add(this.lblName);
            this.groupBox4.Controls.Add(this.tbxName);
            this.groupBox4.Controls.Add(this.lbxDescription);
            this.groupBox4.Controls.Add(this.tbxValue);
            this.groupBox4.Location = new System.Drawing.Point(299, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 248);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add your info:";
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(130, 96);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(68, 26);
            this.btnAddInfo.TabIndex = 5;
            this.btnAddInfo.Text = "Add";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnRemoveInfo
            // 
            this.btnRemoveInfo.Location = new System.Drawing.Point(207, 96);
            this.btnRemoveInfo.Name = "btnRemoveInfo";
            this.btnRemoveInfo.Size = new System.Drawing.Size(73, 26);
            this.btnRemoveInfo.TabIndex = 6;
            this.btnRemoveInfo.Text = "Remove";
            this.btnRemoveInfo.UseVisualStyleBackColor = true;
            this.btnRemoveInfo.Click += new System.EventHandler(this.btnRemoveInfo_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(16, 67);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(48, 17);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Property:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(79, 36);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(122, 22);
            this.tbxName.TabIndex = 1;
            // 
            // lbxDescription
            // 
            this.lbxDescription.FormattingEnabled = true;
            this.lbxDescription.ItemHeight = 16;
            this.lbxDescription.Location = new System.Drawing.Point(19, 128);
            this.lbxDescription.Name = "lbxDescription";
            this.lbxDescription.Size = new System.Drawing.Size(219, 100);
            this.lbxDescription.TabIndex = 0;
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(79, 64);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(122, 22);
            this.tbxValue.TabIndex = 2;
            // 
            // ModifyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 617);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyProfile";
            this.Text = "ModifyProfile";
            this.Load += new System.EventHandler(this.ModifyProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnPageLayout3;
        private System.Windows.Forms.RadioButton rbnPageLayout2;
        private System.Windows.Forms.RadioButton rbnPageLayout1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnCommentLayout3;
        private System.Windows.Forms.RadioButton rbnCommentLayout2;
        private System.Windows.Forms.RadioButton rbnCommentLayout1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox lbxTopics;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ListBox lbxDescription;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnRemoveInfo;
        private System.Windows.Forms.RadioButton rbnCommentLayout4;
        private System.Windows.Forms.TextBox tbxFlair;
        private System.Windows.Forms.Button btnFlair;
    }
}