using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace LiquidLaunchpad
{
	public partial class FormLaunchpad : Form
	{
        #region FormLaunchpad
        public FormLaunchpad()
		{
			this.InitializeComponent();
		}
        #endregion

        #region OnLoad
        private void OnLoad(object sender, EventArgs e)
		{
			IO.CreateWorkingPath();
			this.TimerGameRunning.Start();
			this.TimerAutoInject.Start();
		}
        #endregion

        #region OnClickInject
        static bool IsGTA5Running()
        {
            Process[] processes = Process.GetProcessesByName("GTA5");
            return processes.Length > 0;
        }
        private void OnClickInject(object sender, EventArgs e)
		{
			{
                if (IsGTA5Running())
                {
                    Inject();
                }
                else
                {
                    SoundPlayer ErrorSound = new SoundPlayer("C:/Windows/Media/Windows Foreground.wav");
                    ErrorSound.Play();
                    
                }
            }
		}
        #endregion

        #region OnTickGameRunning
        private void OnTickGameRunning(object sender, EventArgs e)
		{
		}
        #endregion
	
        #region OnClickGetKey
        private void OnClickGetKey(object sender, EventArgs e)
		{
            Process.Start(Config.KeyLink);
			MessageBox.Show("Get rickrolled and flagged again by : BiscuiTheHobkin\r\nBro, really stop scamming ppl for key\r\nLittle skiddi you are~\r\nYou just need yo click on inject while GTA5 Running");
		}
        #endregion

        #region CheckLibrary
        private bool CheckLibrary()
		{
			return IO.IsLibraryFound() || (Network.GetUpdatedLibrary() && Network.GetUpdatedAssets());
		}
        #endregion

        #region Inject
        private void Inject()
		{
			if (!this.CheckLibrary())
			{
				return;
			}
			Memory.Inject(IO.GetLibraryPath());
		}
        #endregion

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
