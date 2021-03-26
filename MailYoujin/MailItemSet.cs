using System;
using System.Configuration;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Drawing;

namespace MailYoujin
{
    class MailItemSet:BaseForm
    {
        /// <summary>
        /// MailItemSetコンストラクタ
        /// </summary>
        /// <param name="item">送信メールのアイテム</param>
        public MailItemSet(object item)
        {
            Outlook.MailItem mailItem = item as Outlook.MailItem;

            //画面設定
            ItemSet();

            //送信アドレスの設定
            SendAddressSet(mailItem);

            //添付ファイルの設定
            AttachmentSet(mailItem);

            SendButtonEnableCheck();
        }

        /// <summary>
        /// メール送信確認画面の初期設定
        /// 画面の基礎情報が会議情報のため、画面アイテムのプロパティをメール確認画面に変更
        /// </summary>
        private void ItemSet()
        {
            
            SendMemberGroupBox.Text  = "送信アドレス";
            InternalMemberLabel.Text = "社内ドメイン";
            ExternalMemberLabel.Text = "社外ドメイン";

            LocationTitleLabel.Visible  = false;
            LocationLabel.Visible       = false;
            TimeTitleLabel.Visible      = false;
            TimeLabel.Visible           = false;


            ExternalMemberLabel.Location        = new Point(10, 167);
            ExternalMemberNumberLabel.Location  = new Point(79, 167);
            ExternalMemberBulkCheckBox.Location = new Point(13, 184);
            ExternalMemberCheckListBox.Location = new Point(10, 205);
            InternalMemberListBox.Height        = 116;
            ExternalMemberCheckListBox.Height   = 116;
        }

        /// <summary>
        /// 送信アドレスの表示
        /// </summary>
        /// <param name="mailItem">送信メールのアイテム</param>
        private void SendAddressSet(Outlook.MailItem mailItem)
        {

            //メールアドレスをSMTPで取得
            Outlook.Recipients recipients = mailItem.Recipients;

            int internalDomainCount = 0;
            int externalDomainCount = 0;
            string strIntDomain 　　= ConfigurationManager.AppSettings["internalDomain"];
            string recipientType;


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
                else if ((int)Outlook.OlMailRecipientType.olCC == recipient.Type)
                {
                    recipientType = "(CC：)";
                }
                else if ((int)Outlook.OlMailRecipientType.olBCC == recipient.Type)
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
                        InternalMemberListBox.Items.Add(recipientType + smtpAddress);
                    }
                    else
                    {
                        //名前が登録されている場合、名前+アドレスを表示
                        InternalMemberListBox.Items.Add(recipientType + recipient.Name + " <" + smtpAddress + ">");
                    }
                    //社内ドメイン件数カウント
                    internalDomainCount++;

                }
                //社外ドメイン
                else
                {
                    if (recipient.Name.Equals(smtpAddress))
                    {
                        ExternalMemberCheckListBox.Items.Add(recipientType + smtpAddress);
                    }
                    else
                    {
                        ExternalMemberCheckListBox.Items.Add(recipientType + recipient.Name + " <" + smtpAddress + ">");
                    }

                    //社外ドメイン件数カウント
                    externalDomainCount++;
                }


            }

            if (ExternalMemberCheckListBox.Items.Count == 0)
            {
                ExternalMemberBulkCheckBox.Enabled = false;
            }

            SendMemberNumberLabel.Text      = recipients.Count    + "件";
            InternalMemberNumberLabel.Text  = internalDomainCount + "件";
            ExternalMemberNumberLabel.Text  = externalDomainCount + "件";
        }

        /// <summary>
        /// 添付ファイルの表示
        /// </summary>
        /// <param name="mailItem">送信メールのアイテム</param>
        private void AttachmentSet(Outlook.MailItem mailItem)
        {

            foreach (Outlook.Attachment attachment in mailItem.Attachments)
            {
                AttachmentCheckListBox.Items.Add(attachment.FileName);
            }

            if (AttachmentCheckListBox.Items.Count == 0)
            {
                AttachmentBulkCheckBox.Enabled = false;
            }
            AttachmentNumberLabel.Text += mailItem.Attachments.Count + "件";
        }


    }
}
