using System;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003380 File Offset: 0x00001580
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLaunchpad());
		}
	}
}
