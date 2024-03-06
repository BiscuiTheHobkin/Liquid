using System;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000347C File Offset: 0x0000167C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLaunchpad());
		}
	}
}
