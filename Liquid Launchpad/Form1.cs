using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	public partial class Form1
	{
		public Form1(string key)
		{
			this.InitializeComponent();
		}

		private void OnClickButtonCancel(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}


		private void OnClickLinkKey(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Config.KeyLink);
		}

		private void OnTextChangedTextKey(object sender, EventArgs e)
		{
		}

		private void FormKeyInput_Load(object sender, EventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}
        private void buttonInject(object sender, EventArgs e)
        {
            Memory.Inject(IO.GetLibraryPath());
        }
    }
}
