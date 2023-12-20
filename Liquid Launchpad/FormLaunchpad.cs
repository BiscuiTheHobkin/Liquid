using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	public partial class FormLaunchpad : Form
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
		}

		private void OnClickInject(object sender, EventArgs e)
		{
			if (new FormKeyInput(this.ValidKey).ShowDialog() == DialogResult.OK)
			{
				this.Inject();
			}
		}

		private void OnTickGameRunning(object sender, EventArgs e)
		{
		}

		private void OnClickIconDiscord(object sender, EventArgs e)
		{
			Process.Start(Config.DiscordLink);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002758 File Offset: 0x00000958
		private void OnClickIconWebsite(object sender, EventArgs e)
		{
			Process.Start(Config.WebsiteLink);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002765 File Offset: 0x00000965
		private void OnClickGetKey(object sender, EventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002772 File Offset: 0x00000972
		private void OnMouseEnterSocialIcon(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000277F File Offset: 0x0000097F
		private void OnMouseLeaveSocialIcon(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000278C File Offset: 0x0000098C
		private bool CheckLibrary()
		{
			return IO.IsLibraryFound() || (Network.GetUpdatedLibrary() && Network.GetUpdatedAssets());
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000027A8 File Offset: 0x000009A8
		private void Inject()
		{
			if (!this.CheckLibrary())
			{
				return;
			}
			Memory.Inject(IO.GetLibraryPath());
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027BE File Offset: 0x000009BE
		private void LabelStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000009 RID: 9
		private string ValidKey;

        private void IconLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
