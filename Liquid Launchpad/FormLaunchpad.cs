using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000003 RID: 3
	public partial class FormLaunchpad : Form
	{
        #region FormLaunchpad
        public FormLaunchpad()
		{
			this.InitializeComponent();
		}
        #endregion

        private void OnLoad(object sender, EventArgs e)
		{
			IO.CreateWorkingPath();
			this.TimerGameRunning.Start();
			this.TimerAutoInject.Start();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002805 File Offset: 0x00000A05
		private void OnClickInject(object sender, EventArgs e)
		{
			{
				this.Inject();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002820 File Offset: 0x00000A20
		private void OnTickGameRunning(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002822 File Offset: 0x00000A22
		private void OnClickIconDiscord(object sender, EventArgs e)
		{
			Process.Start(Config.DiscordLink);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000282F File Offset: 0x00000A2F
		private void OnClickIconWebsite(object sender, EventArgs e)
		{
			Process.Start(Config.WebsiteLink);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000283C File Offset: 0x00000A3C
		private void OnClickGetKey(object sender, EventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002849 File Offset: 0x00000A49
		private void OnMouseEnterSocialIcon(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002856 File Offset: 0x00000A56
		private void OnMouseLeaveSocialIcon(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002863 File Offset: 0x00000A63
		private bool CheckLibrary()
		{
			return IO.IsLibraryFound() || (Network.GetUpdatedLibrary() && Network.GetUpdatedAssets());
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000287F File Offset: 0x00000A7F
		private void Inject()
		{
			if (!this.CheckLibrary())
			{
				return;
			}
			Memory.Inject(IO.GetLibraryPath());
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002895 File Offset: 0x00000A95
		private void LabelStatus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000009 RID: 9
		private string ValidKey;
    }
}
