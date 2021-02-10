using System;
using System.Windows.Forms;
using System.Configuration;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace MailYoujin
{
    public partial class MainForm : Form
    {
        private bool isExtDomainBulkCheckEvent  = true;
        private bool isAttachmentBulkCheckEvent = true;

        /// <summary>
        /// MainFormの初期化処理
        /// </summary>
        /// <param name="item">送信メールのアイテム</param>
        public MainForm(object item)
        {
            InitializeComponent();

            //受信アドレスの判定
            SendAdressCheck(item);

            if(ExternalDomainCheckBox.Items.Count == 0)
            {
                ExternalDomainBulkCheckBox.Enabled = false;
            }

            //添付ファイルの判定
            AttachmentCheck(item);
            
            if (AttachmentCheckBox.Items.Count == 0)
            {
                AttachmentBulkCheckBox.Enabled = false;
            }

            //送信ボタンの活性非活性確認
            SendButtonEnableCheck();
        }


        /// <summary>
        /// アドレスの判定
        /// </summary>
        /// <param name="item">送信メールのアイテム</param>
        private void SendAdressCheck(object item)
        {

            //メールアドレスをSMTPで取得
            Outlook.MailItem   mailItem     = item as Outlook.MailItem;
            Outlook.Recipients recipients   = mailItem.Recipients;

            int     internalDomainCount     = 0;
            int     externalDomainCount     = 0;
            string　strIntDomain            = ConfigurationManager.AppSettings["internalDomain"];
            string  recipientType;


            const string PR_SMTP_ADDRESS =
                  "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";

            foreach (Outlook.Recipient recipient in recipients)
            {
                //受信者のアドレスを取得。
                    //Outlookに名前が登録されている場合、名前しか取得できない。
                    //SMTPはメール送信サーバのプロトコル。
                Outlook.PropertyAccessor propertyAccessor = recipient.PropertyAccessor;
                string smtpAddress = propertyAccessor.GetProperty(PR_SMTP_ADDRESS).ToString();


                //宛先判定
                if ((int)Outlook.OlMailRecipientType.olTo == recipient.Type)
                {
                    recipientType = "(TO：)";
                }
                else if ((int) Outlook.OlMailRecipientType.olCC == recipient.Type)
                {
                    recipientType = "(CC：)";
                }
                else if ((int) Outlook.OlMailRecipientType.olBCC == recipient.Type)
                {
                    recipientType = "(BCC：)";
                }
                else
                {
                    recipientType = String.Empty;
                }

                bool isIntDomain = smtpAddress.Contains(strIntDomain); 

                //社内ドメイン
                if (isIntDomain == true)
                {
                    //Outlookに名前が登録されているかの判定
                    if (recipient.Name.Equals(smtpAddress))
                    {
                        //名前が登録されていない場合、アドレスのみ表示
                        InternalDomainListBox.Items.Add(recipientType + smtpAddress);
                    }
                    else
                    {
                        //名前が登録されている場合、名前+アドレスを表示
                        InternalDomainListBox.Items.Add(recipientType + recipient.Name + " <" + smtpAddress + ">");
                    }
                    //社内ドメイン件数カウント
                    internalDomainCount++;

                }
                //社外ドメイン
                else
                {
                    if (recipient.Name.Equals(smtpAddress))
                    {
                        ExternalDomainCheckBox.Items.Add(recipientType + smtpAddress);
                    }
                    else
                    {
                        ExternalDomainCheckBox.Items.Add(recipientType + recipient.Name + " <" + smtpAddress + ">");
                    }

                    //社外ドメイン件数カウント
                    externalDomainCount++;
                }


            }

            SendAdressNumberLabel.Text      += recipients.Count         + "件";
            InternalDomainNumberLabel.Text  += internalDomainCount      + "件";
            ExternalDomainNumberLabel.Text  += externalDomainCount      + "件";

        }

        /// <summary>
        /// 添付ファイルの表示
        /// </summary>
        /// <param name="item">送信メールのアイテム</param>
        private void AttachmentCheck(object item)
        {
            Outlook._MailItem mailItem = item as Outlook._MailItem;

            foreach (Outlook.Attachment attachment in mailItem.Attachments)
            {
                AttachmentCheckBox.Items.Add(attachment.FileName);
            }

            AttachmentNumberLabel.Text += mailItem.Attachments.Count+"件";
        }

        /// <summary>
        /// 送信ボタンの押下時処理
        /// </summary>
        private void SendButton_Click(object sender, EventArgs e)
        {
            SendButton.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// キャンセルボタンの押下時処理
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButton.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 社外ドメインチェックボックスのチェック時処理
        /// </summary>
        private void ExternalDomainCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //チェックボックスがチェックされた場合
            if(e.NewValue == CheckState.Checked)
            {
                //チェックされたことによってすべてチェックがついた場合
                if (ExternalDomainCheckBox.Items.Count == ExternalDomainCheckBox.CheckedItems.Count + 1)
                {
                    isExtDomainBulkCheckEvent           = false;
                    ExternalDomainBulkCheckBox.Checked  = true;
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
                if (ExternalDomainCheckBox.Items.Count == ExternalDomainCheckBox.CheckedItems.Count )
                {
                    isExtDomainBulkCheckEvent           = false;
                    ExternalDomainBulkCheckBox.Checked  = false;
                }
                else
                {
                    return;
                }
            }
        }


        /// <summary>
        /// 社外ドメイン一括チェック
        /// </summary>
        private void ExternalDomainBulkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            bool isChecked = ExternalDomainBulkCheckBox.Checked;

            if (isExtDomainBulkCheckEvent)
            {
                for (int i = 0; i < ExternalDomainCheckBox.Items.Count; i++)
                {
                    ExternalDomainCheckBox.SetItemChecked(i, isChecked);
                }
            }
            else
            {
                //イベント発生無
            }

            isExtDomainBulkCheckEvent = true;
            //送信ボタン活性化チェック
            SendButtonEnableCheck();
        }

        /// <summary>
        /// 添付ファイルチェックボックスのチェック時処理
        /// </summary>
        private void AttachmentCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {

                if (AttachmentCheckBox.Items.Count == AttachmentCheckBox.CheckedItems.Count + 1)
                {
                    isAttachmentBulkCheckEvent     = false;
                    AttachmentBulkCheckBox.Checked = true;
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (AttachmentCheckBox.Items.Count == AttachmentCheckBox.CheckedItems.Count)
                {
                    isAttachmentBulkCheckEvent     = false;
                    AttachmentBulkCheckBox.Checked = false;
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// 添付ファイル一括チェック
        /// </summary>
        private void AttachmentBulkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = AttachmentBulkCheckBox.Checked;

            if (isAttachmentBulkCheckEvent)
            {
                for (int i = 0; i < AttachmentCheckBox.Items.Count; i++)
                {
                    AttachmentCheckBox.SetItemChecked(i, isChecked);
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
        /// 送信ボタンの活性、非活性チェック
        /// </summary>
        private void SendButtonEnableCheck()
        {
            //チェックが全て行われていた場合、送信ボタンを活性化
            if (((ExternalDomainBulkCheckBox.Checked    == true) && (AttachmentBulkCheckBox.Checked     == true))
                || ((ExternalDomainCheckBox.Items.Count == 0)    && (AttachmentCheckBox.Items.Count     == 0))
                || ((ExternalDomainBulkCheckBox.Checked == true) && (AttachmentCheckBox.Items.Count     == 0))
                || ((AttachmentBulkCheckBox.Checked     == true) && (ExternalDomainCheckBox.Items.Count == 0)))
            {
                SendButton.Enabled = true;
            }
            else
            {
                SendButton.Enabled = false;
            }

        }

    }
}
