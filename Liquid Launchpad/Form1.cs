using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000002 RID: 2
	public partial class Form1
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public Form1(string key)
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002069 File Offset: 0x00000269
		private void OnClickButtonCancel(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}


		// Token: 0x06000004 RID: 4 RVA: 0x00002085 File Offset: 0x00000285
		private void OnClickLinkKey(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002092 File Offset: 0x00000292
		private void OnTextChangedTextKey(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002094 File Offset: 0x00000294
		private void FormKeyInput_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002098 File Offset: 0x00000298
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private string ValidKey;

        private void buttonInject(object sender, EventArgs e)
        {
            Memory.Inject(IO.GetLibraryPath());
        }
    }
}
