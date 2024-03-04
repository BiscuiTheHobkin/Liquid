using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000002 RID: 2
	public partial class FormKeyInput : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public FormKeyInput(string key)
		{
			this.InitializeComponent();
			this.ButtonOk.Enabled = true;
			this.ValidKey = key;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00000269
		private void OnClickButtonCancel(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		private void OnClickButtonOk(object sender, EventArgs e)
		{
			if (this.TextKey.Text.Trim() == this.ValidKey.Trim())
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			MessageBox.Show("Please enter a valid activation key.");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020B5 File Offset: 0x000002B5
		private void OnClickLinkKey(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020C2 File Offset: 0x000002C2
		private void OnTextChangedTextKey(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020C4 File Offset: 0x000002C4
		private void FormKeyInput_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C6 File Offset: 0x000002C6
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private string ValidKey;
	}
}
