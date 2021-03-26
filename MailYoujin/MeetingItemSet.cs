using System;
using System.Configuration;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;

namespace MailYoujin
{
    class MeetingItemSet:BaseForm
    {

        /// <summary>
        /// MeetingItemSetのコンストラクタ
        /// </summary>
        /// <param name="item">会議出席依頼メールのアイテム</param>
        public MeetingItemSet(object item)
        {

            Outlook.MeetingItem meetingItem = item as Outlook.MeetingItem;

            //会議情報の設定
            ItemSet(meetingItem);

            //出席者の設定
            SendAttendeesSet(meetingItem);

            //添付ファイルの設定
            AttachmentSet(meetingItem);

            //送信ボタンの活性非活性チェック
            SendButtonEnableCheck();

        }
        
        /// <summary>
        /// 会議情報の表示処理
        /// </summary>
        /// <param name="meetingItem">会議出席依頼メールのアイテム</param>
        private void ItemSet(Outlook.MeetingItem meetingItem)
        {
            //場所の表示
            String location = meetingItem.GetAssociatedAppointment(false).Location;
            LocationLabel.Text += location;

            //時刻の表示
            DateTime start  = meetingItem.GetAssociatedAppointment(false).Start;
            DateTime end    = meetingItem.GetAssociatedAppointment(false).End;
            TimeLabel.Text += start.ToString("yyyy/MM/dd H:mm") + " ～ " + end.ToString("yyyy/MM/dd H:mm");
        }
        
        /// <summary>
        /// 会議出席者の表示処理
        /// </summary>
        /// <param name="meetingItem">会議出席依頼メールのアイテム</param>
        private void SendAttendeesSet(Outlook.MeetingItem meetingItem)
        {

            //メールアドレスをSMTPで取得
            Outlook.Recipients recipients   = meetingItem.Recipients;

            int internalAttendeesCount = 0;
            int externalAttendeesCount = 0;
            string strIntDomain        = ConfigurationManager.AppSettings["internalDomain"];
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
                if ((int)Outlook.OlMeetingRecipientType.olRequired == recipient.Type)
                {
                    recipientType = "(必須:)";
                }
                else if ((int)Outlook.OlMeetingRecipientType.olOptional == recipient.Type)
                {
                    recipientType = "(任意:)";
                }
                else if ((int)Outlook.OlMeetingRecipientType.olResource == recipient.Type)
                {
                    continue;
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
                    internalAttendeesCount++;

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
                    externalAttendeesCount++;
                }


            }

            if (ExternalMemberCheckListBox.Items.Count == 0)
            {
                ExternalMemberBulkCheckBox.Enabled = false;
            }

            SendMemberNumberLabel.Text     = "出席者:" + (internalAttendeesCount+ externalAttendeesCount) + "名";
            InternalMemberNumberLabel.Text = internalAttendeesCount + "名";
            ExternalMemberNumberLabel.Text = externalAttendeesCount + "名";
        }

        /// <summary>
        /// 添付ファイルの表示
        /// </summary>
        /// <param name="item">会議出席依頼メールのアイテム</param>
        private void AttachmentSet(Outlook.MeetingItem meetingItem)
        {

            foreach (Outlook.Attachment attachment in meetingItem.Attachments)
            {
                AttachmentCheckListBox.Items.Add(attachment.FileName);
            }

            if (AttachmentCheckListBox.Items.Count == 0)
            {
                AttachmentBulkCheckBox.Enabled = false;
            }
            AttachmentNumberLabel.Text += meetingItem.Attachments.Count + "件";
        }
    }
}
