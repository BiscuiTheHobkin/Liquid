using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000003 RID: 3
	public partial class FormLaunchpad : global::System.Windows.Forms.Form
    {
		// Token: 0x0600000B RID: 11 RVA: 0x00002572 File Offset: 0x00000772
		public FormLaunchpad()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002580 File Offset: 0x00000780
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
			string address2 = string.Format("https://raw.githubusercontent.com/SkeyGitHub/fl/main/lq/clog?nocache={0}", DateTime.UtcNow.Ticks);
			string text3 = webClient.DownloadString(address2).Trim();
			this.richTextBox1.Text = text3;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026C8 File Offset: 0x000008C8
		private void OnClickInject(object sender, EventArgs e)
		{
				Form1 form = new Form1(this.textBox1.Text);
				base.Hide();
				form.ShowDialog();
				base.Close();
				return;
			}
		

		// Token: 0x0600000E RID: 14 RVA: 0x00002725 File Offset: 0x00000925
		private void OnTickGameRunning(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002727 File Offset: 0x00000927
		private void OnClickIconDiscord(object sender, EventArgs e)
		{
			Process.Start(Config.DiscordLink);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002734 File Offset: 0x00000934
		private void OnClickIconWebsite(object sender, EventArgs e)
		{
			Process.Start(Config.WebsiteLink);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002741 File Offset: 0x00000941
		private void OnClickGetKey(object sender, EventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000274E File Offset: 0x0000094E

		// Token: 0x06000013 RID: 19 RVA: 0x0000275B File Offset: 0x0000095B


		// Token: 0x06000014 RID: 20 RVA: 0x00002768 File Offset: 0x00000968
		private bool CheckLibrary()
		{
			return IO.IsLibraryFound() || (Network.GetUpdatedLibrary() && Network.GetUpdatedAssets());
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002784 File Offset: 0x00000984
		private void Inject()
		{
			if (!this.CheckLibrary())
			{
				return;
			}
			Memory.Inject(IO.GetLibraryPath());
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000279A File Offset: 0x0000099A
		private void LabelStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000279C File Offset: 0x0000099C
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000279E File Offset: 0x0000099E
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000027A0 File Offset: 0x000009A0
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000007 RID: 7
		private string ValidKey;
	}
}
