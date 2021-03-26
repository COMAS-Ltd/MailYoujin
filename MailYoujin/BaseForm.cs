using System;
using System.Windows.Forms;

namespace MailYoujin
{
    public partial class BaseForm : Form
    {
        private bool isExtMemberBulkCheckEvent  = true;
        private bool isAttachmentBulkCheckEvent = true;

        public BaseForm()
        {
            InitializeComponent();
        }

        protected void SendButtonEnableCheck()
        {
            //チェックが全て行われていた場合、送信ボタンを活性化
            if (((ExternalMemberBulkCheckBox.Checked        == true) && (AttachmentBulkCheckBox.Checked         == true))
                || ((ExternalMemberCheckListBox.Items.Count == 0)    && (AttachmentCheckListBox.Items.Count     == 0))
                || ((ExternalMemberBulkCheckBox.Checked     == true) && (AttachmentCheckListBox.Items.Count     == 0))
                || ((ExternalMemberCheckListBox.Items.Count == 0)    && (AttachmentBulkCheckBox.Checked         == true) ))
            {
                SendButton.Enabled = true;
            }
            else
            {
                SendButton.Enabled = false;
            }
        }
       
        /// <summary>
        ///社外メンバーチェックリストボックスチェック処理 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExternalMemberCheckListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //チェックボックスがチェックされた場合
            if (e.NewValue == CheckState.Checked)
            {
                //チェックされたことによってすべてチェックがついた場合
                if (ExternalMemberCheckListBox.Items.Count == ExternalMemberCheckListBox.CheckedItems.Count + 1)
                {
                    //社外一括チェックイベントハンドラ内の処理抑止フラグOff
                    isExtMemberBulkCheckEvent          = false;
                    ExternalMemberBulkCheckBox.Checked = true;
                }
                else
                {
                    return;
                }
            }
            //チェックが外された場合
            else
            {
                //チェックがはずれされる前に全てのチェックがついていた場合
                if (ExternalMemberCheckListBox.Items.Count == ExternalMemberCheckListBox.CheckedItems.Count)
                {
                    //社外一括チェックイベントハンドラ内の処理抑止フラグOff
                    isExtMemberBulkCheckEvent = false;
                    ExternalMemberBulkCheckBox.Checked = false;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 社外メンバー一括チェック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExternalMemberBulkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ExternalMemberBulkCheckBox.Checked;

            if (isExtMemberBulkCheckEvent)
            {
                for (int i = 0; i < ExternalMemberCheckListBox.Items.Count; i++)
                {
                    ExternalMemberCheckListBox.SetItemChecked(i, isChecked);
                }
            }
            else
            {
                //イベント発生無
            }

            isExtMemberBulkCheckEvent = true;
            //送信ボタン活性化チェック
            SendButtonEnableCheck();
        }

        /// <summary>
        /// 添付ファイルチェックリストボックスチェック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttachmentCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {

                if (AttachmentCheckListBox.Items.Count == AttachmentCheckListBox.CheckedItems.Count + 1)
                {
                    //添付ファイルチェックイベントハンドラ内の処理抑止フラグOff
                    isAttachmentBulkCheckEvent = false;
                    AttachmentBulkCheckBox.Checked = true;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (AttachmentCheckListBox.Items.Count == AttachmentCheckListBox.CheckedItems.Count)
                {
                    //添付ファイル一括チェックイベントハンドラ内の処理抑止フラグOff
                    isAttachmentBulkCheckEvent = false;
                    AttachmentBulkCheckBox.Checked = false;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 添付ファイル一括チェック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttachmentBulkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = AttachmentBulkCheckBox.Checked;

            if (isAttachmentBulkCheckEvent)
            {
                for (int i = 0; i < AttachmentCheckListBox.Items.Count; i++)
                {
                    AttachmentCheckListBox.SetItemChecked(i, isChecked);
                }
            }
            else
            {
                //イベント発生無
            }

            isAttachmentBulkCheckEvent = true;

            //送信ボタン活性化チェック
            SendButtonEnableCheck();
        }

        /// <summary>
        /// 送信ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// キャンセルボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
