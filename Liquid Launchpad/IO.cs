using System;
using System.IO;

namespace LiquidLaunchpad
{
	// Token: 0x02000004 RID: 4
	internal class IO
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00003168 File Offset: 0x00001368
		public static string GetWorkingPath()
		{
			return Path.Combine("C:\\", Config.WorkingDirectoryName);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000317C File Offset: 0x0000137C
		public static void CreateWorkingPath()
		{
			string workingPath = IO.GetWorkingPath();
			if (!Directory.Exists(workingPath))
			{
				Directory.CreateDirectory(workingPath);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000319E File Offset: 0x0000139E
		public static string GetLibraryPath()
		{
			return Path.Combine(IO.GetWorkingPath(), Config.LibraryName);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000031AF File Offset: 0x000013AF
		public static bool IsLibraryFound()
		{
			return File.Exists(IO.GetLibraryPath());
		}
	}
}
