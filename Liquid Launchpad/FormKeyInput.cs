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
			if (this.TextKey.Text == this.ValidKey)
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			MessageBox.Show("Please enter a valid activation key.");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020AB File Offset: 0x000002AB
		private void OnClickLinkKey(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020B8 File Offset: 0x000002B8
		private void OnTextChangedTextKey(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020BA File Offset: 0x000002BA
		private void FormKeyInput_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020BC File Offset: 0x000002BC
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private string ValidKey;

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
