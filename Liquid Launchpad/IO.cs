using System;
using System.IO;

namespace LiquidLaunchpad
{
	// Token: 0x02000004 RID: 4
	internal class IO
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002EE2 File Offset: 0x000010E2
		public static string GetWorkingPath()
		{
			return Path.Combine("C:\\", Config.WorkingDirectoryName);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002EF4 File Offset: 0x000010F4
		public static void CreateWorkingPath()
		{
			string workingPath = IO.GetWorkingPath();
			if (!Directory.Exists(workingPath))
			{
				Directory.CreateDirectory(workingPath);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F16 File Offset: 0x00001116
		public static string GetLibraryPath()
		{
			return Path.Combine(IO.GetWorkingPath(), Config.LibraryName);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002F27 File Offset: 0x00001127
		public static bool IsLibraryFound()
		{
			return File.Exists(IO.GetLibraryPath());
		}
	}
}
