using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	public partial class FormLaunchpad : global::System.Windows.Forms.Form
    {
		public FormLaunchpad()
		{
			this.InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			this.ValidKey = Network.GetUpdatedKey();
			IO.CreateWorkingPath();
			this.TimerGameRunning.Start();
			this.TimerAutoInject.Start();
			WebClient webClient = new WebClient();
			webClient.Proxy = null;
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
			string address = string.Format("https://raw.githubusercontent.com/SkeyGitHub/fl/main/lq/status2?nocache={0}", DateTime.UtcNow.Ticks);
			string a = webClient.DownloadString(address).Trim();
			if (!(a == "1"))
			{
				if (a == "0")
				{
					string text = "LiquidLauncher has found an Update. Running this version could cause problems or work incorrectly. Do you want to open liquidmenu.pro to download the latest version?";
					string caption = "Update";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					if (MessageBox.Show(text, caption, buttons) == DialogResult.Yes)
					{
						Process.Start(Config.WebsiteLink);
					}
				}
				else if (a == "-1")
				{
					string text2 = "LiquidLauncher has found a Major Update. Running this version will cause problems. Do you want to open liquidmenu.pro to download the latest version?";
					string caption2 = "Update";
					MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
					if (MessageBox.Show(text2, caption2, buttons2) == DialogResult.Yes)
					{
						Process.Start(Config.WebsiteLink);
					}
					base.Close();
				}
			}
			webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
			string address2 = string.Format("https://raw.githubusercontent.com/BiscuiTheHobkin/Liquid/main/Resources/clog", DateTime.UtcNow.Ticks);
			string text3 = webClient.DownloadString(address2).Trim();
			this.richTextBox1.Text = text3;
		}

		private void OnClickInject(object sender, EventArgs e)
		{
				Form1 form = new Form1(this.textBox1.Text);
				base.Hide();
				form.ShowDialog();
				base.Close();
				return;
			}
		

		private void OnTickGameRunning(object sender, EventArgs e)
		{
		}

		private void OnClickGetKey(object sender, EventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		private bool CheckLibrary()
		{
			return IO.IsLibraryFound() || (Network.GetUpdatedLibrary() && Network.GetUpdatedAssets());
		}

		private void Inject()
		{
			if (!this.CheckLibrary())
			{
				return;
			}
			Memory.Inject(IO.GetLibraryPath());
		}

		private async void LabelStatus_Click(object sender, EventArgs e)
        {
            this.LabelStatus.Text = "Biscuit was here x3";
			await Task.Delay(1000);
            this.LabelStatus.Text = "made with ❤ by bypass_";
        }

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private string ValidKey;
	}
}
