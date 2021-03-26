
namespace MailYoujin
{
    partial class BaseForm
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
            this.AttachmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AttachmentNumberLabel = new System.Windows.Forms.Label();
            this.AttachmentBulkCheckBox = new System.Windows.Forms.CheckBox();
            this.AttachmentCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.ExternalMemberCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.InternalMemberLabel = new System.Windows.Forms.Label();
            this.ExternalMemberLabel = new System.Windows.Forms.Label();
            this.ExternalMemberBulkCheckBox = new System.Windows.Forms.CheckBox();
            this.InternalMemberListBox = new System.Windows.Forms.ListBox();
            this.InternalMemberNumberLabel = new System.Windows.Forms.Label();
            this.ExternalMemberNumberLabel = new System.Windows.Forms.Label();
            this.LocationTitleLabel = new System.Windows.Forms.Label();
            this.TimeTitleLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SendMemberNumberLabel = new System.Windows.Forms.Label();
            this.SendMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.AttachmentGroupBox.SuspendLayout();
            this.SendMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttachmentGroupBox
            // 
            this.AttachmentGroupBox.Controls.Add(this.AttachmentNumberLabel);
            this.AttachmentGroupBox.Controls.Add(this.AttachmentBulkCheckBox);
            this.AttachmentGroupBox.Controls.Add(this.AttachmentCheckListBox);
            this.AttachmentGroupBox.Location = new System.Drawing.Point(19, 360);
            this.AttachmentGroupBox.Name = "AttachmentGroupBox";
            this.AttachmentGroupBox.Size = new System.Drawing.Size(511, 135);
            this.AttachmentGroupBox.TabIndex = 11;
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
            this.AttachmentBulkCheckBox.TabIndex = 4;
            this.AttachmentBulkCheckBox.Text = "一括チェック";
            this.AttachmentBulkCheckBox.UseVisualStyleBackColor = true;
            this.AttachmentBulkCheckBox.CheckedChanged += new System.EventHandler(this.AttachmentBulkCheckBox_CheckedChanged);
            // 
            // AttachmentCheckListBox
            // 
            this.AttachmentCheckListBox.CheckOnClick = true;
            this.AttachmentCheckListBox.FormattingEnabled = true;
            this.AttachmentCheckListBox.Location = new System.Drawing.Point(10, 45);
            this.AttachmentCheckListBox.Name = "AttachmentCheckListBox";
            this.AttachmentCheckListBox.Size = new System.Drawing.Size(490, 74);
            this.AttachmentCheckListBox.TabIndex = 5;
            this.AttachmentCheckListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AttachmentCheckBox_ItemCheck);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(454, 503);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(364, 503);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "送信";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ExternalMemberCheckListBox
            // 
            this.ExternalMemberCheckListBox.CheckOnClick = true;
            this.ExternalMemberCheckListBox.ForeColor = System.Drawing.Color.Red;
            this.ExternalMemberCheckListBox.FormattingEnabled = true;
            this.ExternalMemberCheckListBox.Location = new System.Drawing.Point(10, 177);
            this.ExternalMemberCheckListBox.Name = "ExternalMemberCheckListBox";
            this.ExternalMemberCheckListBox.Size = new System.Drawing.Size(490, 88);
            this.ExternalMemberCheckListBox.TabIndex = 3;
            this.ExternalMemberCheckListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ExternalMemberCheckListBox_ItemCheck);
            // 
            // InternalMemberLabel
            // 
            this.InternalMemberLabel.AutoSize = true;
            this.InternalMemberLabel.Location = new System.Drawing.Point(10, 20);
            this.InternalMemberLabel.Name = "InternalMemberLabel";
            this.InternalMemberLabel.Size = new System.Drawing.Size(65, 12);
            this.InternalMemberLabel.TabIndex = 3;
            this.InternalMemberLabel.Text = "社内出席者";
            // 
            // ExternalMemberLabel
            // 
            this.ExternalMemberLabel.AutoSize = true;
            this.ExternalMemberLabel.Location = new System.Drawing.Point(10, 140);
            this.ExternalMemberLabel.Name = "ExternalMemberLabel";
            this.ExternalMemberLabel.Size = new System.Drawing.Size(65, 12);
            this.ExternalMemberLabel.TabIndex = 4;
            this.ExternalMemberLabel.Text = "社外参加者";
            // 
            // ExternalMemberBulkCheckBox
            // 
            this.ExternalMemberBulkCheckBox.AutoSize = true;
            this.ExternalMemberBulkCheckBox.Location = new System.Drawing.Point(13, 157);
            this.ExternalMemberBulkCheckBox.Name = "ExternalMemberBulkCheckBox";
            this.ExternalMemberBulkCheckBox.Size = new System.Drawing.Size(79, 16);
            this.ExternalMemberBulkCheckBox.TabIndex = 2;
            this.ExternalMemberBulkCheckBox.Text = "一括チェック";
            this.ExternalMemberBulkCheckBox.UseVisualStyleBackColor = true;
            this.ExternalMemberBulkCheckBox.CheckedChanged += new System.EventHandler(this.ExternalMemberBulkCheckBox_CheckedChanged);
            // 
            // InternalMemberListBox
            // 
            this.InternalMemberListBox.FormattingEnabled = true;
            this.InternalMemberListBox.ItemHeight = 12;
            this.InternalMemberListBox.Location = new System.Drawing.Point(10, 39);
            this.InternalMemberListBox.Name = "InternalMemberListBox";
            this.InternalMemberListBox.Size = new System.Drawing.Size(490, 88);
            this.InternalMemberListBox.TabIndex = 0;
            this.InternalMemberListBox.TabStop = false;
            // 
            // InternalMemberNumberLabel
            // 
            this.InternalMemberNumberLabel.AutoSize = true;
            this.InternalMemberNumberLabel.Location = new System.Drawing.Point(79, 20);
            this.InternalMemberNumberLabel.Name = "InternalMemberNumberLabel";
            this.InternalMemberNumberLabel.Size = new System.Drawing.Size(0, 12);
            this.InternalMemberNumberLabel.TabIndex = 7;
            // 
            // ExternalMemberNumberLabel
            // 
            this.ExternalMemberNumberLabel.AutoSize = true;
            this.ExternalMemberNumberLabel.Location = new System.Drawing.Point(79, 140);
            this.ExternalMemberNumberLabel.Name = "ExternalMemberNumberLabel";
            this.ExternalMemberNumberLabel.Size = new System.Drawing.Size(0, 12);
            this.ExternalMemberNumberLabel.TabIndex = 9;
            // 
            // LocationTitleLabel
            // 
            this.LocationTitleLabel.AutoSize = true;
            this.LocationTitleLabel.Location = new System.Drawing.Point(10, 279);
            this.LocationTitleLabel.Name = "LocationTitleLabel";
            this.LocationTitleLabel.Size = new System.Drawing.Size(35, 12);
            this.LocationTitleLabel.TabIndex = 10;
            this.LocationTitleLabel.Text = "場所：";
            // 
            // TimeTitleLabel
            // 
            this.TimeTitleLabel.AutoSize = true;
            this.TimeTitleLabel.Location = new System.Drawing.Point(10, 306);
            this.TimeTitleLabel.Name = "TimeTitleLabel";
            this.TimeTitleLabel.Size = new System.Drawing.Size(35, 12);
            this.TimeTitleLabel.TabIndex = 11;
            this.TimeTitleLabel.Text = "時刻：";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(57, 279);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(0, 12);
            this.LocationLabel.TabIndex = 12;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(57, 306);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 12);
            this.TimeLabel.TabIndex = 13;
            // 
            // SendMemberNumberLabel
            // 
            this.SendMemberNumberLabel.AutoSize = true;
            this.SendMemberNumberLabel.Location = new System.Drawing.Point(79, 0);
            this.SendMemberNumberLabel.Name = "SendMemberNumberLabel";
            this.SendMemberNumberLabel.Size = new System.Drawing.Size(47, 12);
            this.SendMemberNumberLabel.TabIndex = 14;
            this.SendMemberNumberLabel.Text = "出席者：";
            // 
            // SendMemberGroupBox
            // 
            this.SendMemberGroupBox.Controls.Add(this.SendMemberNumberLabel);
            this.SendMemberGroupBox.Controls.Add(this.TimeLabel);
            this.SendMemberGroupBox.Controls.Add(this.LocationLabel);
            this.SendMemberGroupBox.Controls.Add(this.TimeTitleLabel);
            this.SendMemberGroupBox.Controls.Add(this.LocationTitleLabel);
            this.SendMemberGroupBox.Controls.Add(this.ExternalMemberNumberLabel);
            this.SendMemberGroupBox.Controls.Add(this.InternalMemberNumberLabel);
            this.SendMemberGroupBox.Controls.Add(this.InternalMemberListBox);
            this.SendMemberGroupBox.Controls.Add(this.ExternalMemberBulkCheckBox);
            this.SendMemberGroupBox.Controls.Add(this.ExternalMemberLabel);
            this.SendMemberGroupBox.Controls.Add(this.InternalMemberLabel);
            this.SendMemberGroupBox.Controls.Add(this.ExternalMemberCheckListBox);
            this.SendMemberGroupBox.Location = new System.Drawing.Point(19, 15);
            this.SendMemberGroupBox.Name = "SendMemberGroupBox";
            this.SendMemberGroupBox.Size = new System.Drawing.Size(511, 337);
            this.SendMemberGroupBox.TabIndex = 10;
            this.SendMemberGroupBox.TabStop = false;
            this.SendMemberGroupBox.Text = "会議情報";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 538);
            this.Controls.Add(this.SendMemberGroupBox);
            this.Controls.Add(this.AttachmentGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailYoujin";
            this.AttachmentGroupBox.ResumeLayout(false);
            this.AttachmentGroupBox.PerformLayout();
            this.SendMemberGroupBox.ResumeLayout(false);
            this.SendMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private new System.Windows.Forms.Button CancelButton;
        protected System.Windows.Forms.GroupBox AttachmentGroupBox;
        protected System.Windows.Forms.Label AttachmentNumberLabel;
        protected System.Windows.Forms.CheckBox AttachmentBulkCheckBox;
        protected System.Windows.Forms.CheckedListBox AttachmentCheckListBox;
        protected System.Windows.Forms.Button SendButton;
        protected System.Windows.Forms.CheckedListBox ExternalMemberCheckListBox;
        protected System.Windows.Forms.Label InternalMemberLabel;
        protected System.Windows.Forms.Label ExternalMemberLabel;
        protected System.Windows.Forms.CheckBox ExternalMemberBulkCheckBox;
        protected System.Windows.Forms.ListBox InternalMemberListBox;
        protected System.Windows.Forms.Label InternalMemberNumberLabel;
        protected System.Windows.Forms.Label ExternalMemberNumberLabel;
        protected System.Windows.Forms.Label LocationTitleLabel;
        protected System.Windows.Forms.Label TimeTitleLabel;
        protected System.Windows.Forms.Label LocationLabel;
        protected System.Windows.Forms.Label TimeLabel;
        protected System.Windows.Forms.Label SendMemberNumberLabel;
        protected System.Windows.Forms.GroupBox SendMemberGroupBox;
    }
}