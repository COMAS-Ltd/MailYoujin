namespace MailYoujin
{
    partial class MainForm
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
            this.SendAdressGroupBox = new System.Windows.Forms.GroupBox();
            this.ExternalDomainNumberLabel = new System.Windows.Forms.Label();
            this.SendAdressNumberLabel = new System.Windows.Forms.Label();
            this.InternalDomainNumberLabel = new System.Windows.Forms.Label();
            this.InternalDomainListBox = new System.Windows.Forms.ListBox();
            this.ExternalDomainBulkCheckBox = new System.Windows.Forms.CheckBox();
            this.ExternalDomainLabel = new System.Windows.Forms.Label();
            this.InternalDomainLabel = new System.Windows.Forms.Label();
            this.ExternalDomainCheckBox = new System.Windows.Forms.CheckedListBox();
            this.AttachmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AttachmentNumberLabel = new System.Windows.Forms.Label();
            this.AttachmentBulkCheckBox = new System.Windows.Forms.CheckBox();
            this.AttachmentCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SendAdressGroupBox.SuspendLayout();
            this.AttachmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendAdressGroupBox
            // 
            this.SendAdressGroupBox.Controls.Add(this.ExternalDomainNumberLabel);
            this.SendAdressGroupBox.Controls.Add(this.SendAdressNumberLabel);
            this.SendAdressGroupBox.Controls.Add(this.InternalDomainNumberLabel);
            this.SendAdressGroupBox.Controls.Add(this.InternalDomainListBox);
            this.SendAdressGroupBox.Controls.Add(this.ExternalDomainBulkCheckBox);
            this.SendAdressGroupBox.Controls.Add(this.ExternalDomainLabel);
            this.SendAdressGroupBox.Controls.Add(this.InternalDomainLabel);
            this.SendAdressGroupBox.Controls.Add(this.ExternalDomainCheckBox);
            this.SendAdressGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SendAdressGroupBox.Name = "SendAdressGroupBox";
            this.SendAdressGroupBox.Size = new System.Drawing.Size(511, 310);
            this.SendAdressGroupBox.TabIndex = 0;
            this.SendAdressGroupBox.TabStop = false;
            this.SendAdressGroupBox.Text = "送信アドレス";
            // 
            // ExternalDomainNumberLabel
            // 
            this.ExternalDomainNumberLabel.AutoSize = true;
            this.ExternalDomainNumberLabel.Location = new System.Drawing.Point(76, 155);
            this.ExternalDomainNumberLabel.Name = "ExternalDomainNumberLabel";
            this.ExternalDomainNumberLabel.Size = new System.Drawing.Size(35, 12);
            this.ExternalDomainNumberLabel.TabIndex = 9;
            this.ExternalDomainNumberLabel.Text = "件数：";
            // 
            // SendAdressNumberLabel
            // 
            this.SendAdressNumberLabel.AutoSize = true;
            this.SendAdressNumberLabel.Location = new System.Drawing.Point(76, 0);
            this.SendAdressNumberLabel.Name = "SendAdressNumberLabel";
            this.SendAdressNumberLabel.Size = new System.Drawing.Size(35, 12);
            this.SendAdressNumberLabel.TabIndex = 8;
            this.SendAdressNumberLabel.Text = "件数：";
            // 
            // InternalDomainNumberLabel
            // 
            this.InternalDomainNumberLabel.AutoSize = true;
            this.InternalDomainNumberLabel.Location = new System.Drawing.Point(76, 20);
            this.InternalDomainNumberLabel.Name = "InternalDomainNumberLabel";
            this.InternalDomainNumberLabel.Size = new System.Drawing.Size(35, 12);
            this.InternalDomainNumberLabel.TabIndex = 7;
            this.InternalDomainNumberLabel.Text = "件数：";
            // 
            // InternalDomainListBox
            // 
            this.InternalDomainListBox.FormattingEnabled = true;
            this.InternalDomainListBox.ItemHeight = 12;
            this.InternalDomainListBox.Location = new System.Drawing.Point(10, 39);
            this.InternalDomainListBox.Name = "InternalDomainListBox";
            this.InternalDomainListBox.Size = new System.Drawing.Size(490, 100);
            this.InternalDomainListBox.TabIndex = 99;
            this.InternalDomainListBox.TabStop = false;
            // 
            // ExternalDomainBulkCheckBox
            // 
            this.ExternalDomainBulkCheckBox.AutoSize = true;
            this.ExternalDomainBulkCheckBox.Location = new System.Drawing.Point(13, 172);
            this.ExternalDomainBulkCheckBox.Name = "ExternalDomainBulkCheckBox";
            this.ExternalDomainBulkCheckBox.Size = new System.Drawing.Size(79, 16);
            this.ExternalDomainBulkCheckBox.TabIndex = 1;
            this.ExternalDomainBulkCheckBox.Text = "一括チェック";
            this.ExternalDomainBulkCheckBox.UseVisualStyleBackColor = true;
            this.ExternalDomainBulkCheckBox.CheckedChanged += new System.EventHandler(this.ExternalDomainBulkCheckBox_CheckedChanged);
            // 
            // ExternalDomainLabel
            // 
            this.ExternalDomainLabel.AutoSize = true;
            this.ExternalDomainLabel.Location = new System.Drawing.Point(10, 155);
            this.ExternalDomainLabel.Name = "ExternalDomainLabel";
            this.ExternalDomainLabel.Size = new System.Drawing.Size(64, 12);
            this.ExternalDomainLabel.TabIndex = 4;
            this.ExternalDomainLabel.Text = "社外ドメイン";
            // 
            // InternalDomainLabel
            // 
            this.InternalDomainLabel.AutoSize = true;
            this.InternalDomainLabel.Location = new System.Drawing.Point(10, 20);
            this.InternalDomainLabel.Name = "InternalDomainLabel";
            this.InternalDomainLabel.Size = new System.Drawing.Size(64, 12);
            this.InternalDomainLabel.TabIndex = 3;
            this.InternalDomainLabel.Text = "社内ドメイン";
            // 
            // ExternalDomainCheckBox
            // 
            this.ExternalDomainCheckBox.CheckOnClick = true;
            this.ExternalDomainCheckBox.ForeColor = System.Drawing.Color.Red;
            this.ExternalDomainCheckBox.FormattingEnabled = true;
            this.ExternalDomainCheckBox.Location = new System.Drawing.Point(10, 193);
            this.ExternalDomainCheckBox.Name = "ExternalDomainCheckBox";
            this.ExternalDomainCheckBox.Size = new System.Drawing.Size(490, 102);
            this.ExternalDomainCheckBox.TabIndex = 2;
            this.ExternalDomainCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ExternalDomainCheckBox_ItemCheck);
            // 
            // AttachmentGroupBox
            // 
            this.AttachmentGroupBox.Controls.Add(this.AttachmentNumberLabel);
            this.AttachmentGroupBox.Controls.Add(this.AttachmentBulkCheckBox);
            this.AttachmentGroupBox.Controls.Add(this.AttachmentCheckBox);
            this.AttachmentGroupBox.Location = new System.Drawing.Point(12, 328);
            this.AttachmentGroupBox.Name = "AttachmentGroupBox";
            this.AttachmentGroupBox.Size = new System.Drawing.Size(510, 156);
            this.AttachmentGroupBox.TabIndex = 1;
            this.AttachmentGroupBox.TabStop = false;
            this.AttachmentGroupBox.Text = "添付ファイル";
            // 
            // AttachmentNumberLabel
            // 
            this.AttachmentNumberLabel.AutoSize = true;
            this.AttachmentNumberLabel.Location = new System.Drawing.Point(76, 0);
            this.AttachmentNumberLabel.Name = "AttachmentNumberLabel";
            this.AttachmentNumberLabel.Size = new System.Drawing.Size(35, 12);
            this.AttachmentNumberLabel.TabIndex = 10;
            this.AttachmentNumberLabel.Text = "件数：";
            // 
            // AttachmentBulkCheckBox
            // 
            this.AttachmentBulkCheckBox.AutoSize = true;
            this.AttachmentBulkCheckBox.Location = new System.Drawing.Point(13, 23);
            this.AttachmentBulkCheckBox.Name = "AttachmentBulkCheckBox";
            this.AttachmentBulkCheckBox.Size = new System.Drawing.Size(79, 16);
            this.AttachmentBulkCheckBox.TabIndex = 3;
            this.AttachmentBulkCheckBox.Text = "一括チェック";
            this.AttachmentBulkCheckBox.UseVisualStyleBackColor = true;
            this.AttachmentBulkCheckBox.CheckedChanged += new System.EventHandler(this.AttachmentBulkCheckBox_CheckedChanged);
            // 
            // AttachmentCheckBox
            // 
            this.AttachmentCheckBox.CheckOnClick = true;
            this.AttachmentCheckBox.FormattingEnabled = true;
            this.AttachmentCheckBox.Location = new System.Drawing.Point(10, 45);
            this.AttachmentCheckBox.Name = "AttachmentCheckBox";
            this.AttachmentCheckBox.Size = new System.Drawing.Size(490, 102);
            this.AttachmentCheckBox.TabIndex = 4;
            this.AttachmentCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AttachmentCheckBox_ItemCheck);
            // 
            // SendButton
            // 
            this.SendButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(357, 490);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(447, 490);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(542, 526);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AttachmentGroupBox);
            this.Controls.Add(this.SendAdressGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailYoujin";
            this.SendAdressGroupBox.ResumeLayout(false);
            this.SendAdressGroupBox.PerformLayout();
            this.AttachmentGroupBox.ResumeLayout(false);
            this.AttachmentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SendAdressGroupBox;
        private System.Windows.Forms.GroupBox AttachmentGroupBox;
        private System.Windows.Forms.Label ExternalDomainLabel;
        private System.Windows.Forms.Label InternalDomainLabel;
        private System.Windows.Forms.CheckBox ExternalDomainBulkCheckBox;
        private System.Windows.Forms.CheckBox AttachmentBulkCheckBox;
        private System.Windows.Forms.ListBox InternalDomainListBox;
        private System.Windows.Forms.CheckedListBox ExternalDomainCheckBox;
        private System.Windows.Forms.CheckedListBox AttachmentCheckBox;
        private System.Windows.Forms.Button SendButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label ExternalDomainNumberLabel;
        private System.Windows.Forms.Label SendAdressNumberLabel;
        private System.Windows.Forms.Label InternalDomainNumberLabel;
        private System.Windows.Forms.Label AttachmentNumberLabel;
    }
}