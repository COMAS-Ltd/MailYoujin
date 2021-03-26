using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace MailYoujin
{
    public partial class MailYoujin
    {

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
    {
        Application.ItemSend += new Outlook.ApplicationEvents_11_ItemSendEventHandler(Application_ItemSend);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item">送信メールの各アイテム</param>
    /// <param name="isCancel">送信キャンセル判断</param>
    private void Application_ItemSend(object item, ref bool isCancel)
    {
        BaseForm baseForm = null;
        DialogResult result;

        try
        {
            //itemのデータ型によって表示するフォームを判定
            //MailItemの場合はメール確認画面、MeetingItemの場合は会議依頼確認画面とする
            if (item is Outlook.MailItem)
            {
                baseForm = new MailItemSet(item);
            }
            else if (item is Outlook.MeetingItem)
            {
                baseForm = new MeetingItemSet(item);
            }
            else
            {
                return;
            }

            result = baseForm.ShowDialog();

            if (DialogResult.OK == result)
            {
                //送信ボタンが押下されたら送信
            }
            else if (DialogResult.Cancel == result)
            {
                isCancel = true;
            }
            else
            {
                isCancel = true;
            }
        }
        catch (System.Exception e)
        {

            MessageBox.Show($"エラーが発生したため、アドインを停止します。\n" + e.Message,
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

            if (baseForm != null)
            {
                baseForm.Close();
            }

            isCancel = true;
        }
    }

    private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
    {
        //注: Outlook はこのイベントを発行しなくなりました。Outlook が
        //    を Outlook のシャットダウン時に実行する必要があります。https://go.microsoft.com/fwlink/?LinkId=506785 をご覧ください
    }

    #region VSTO で生成されたコード

    /// <summary>
    /// デザイナーのサポートに必要なメソッドです。
    /// このメソッドの内容をコード エディターで変更しないでください。
    /// </summary>
    private void InternalStartup()
    {
        this.Startup += new System.EventHandler(ThisAddIn_Startup);
        this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
    }

    #endregion
}
}
