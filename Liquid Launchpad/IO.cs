using System;
using System.IO;

namespace LiquidLaunchpad
{
	// Token: 0x02000004 RID: 4
	internal class IO
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000306E File Offset: 0x0000126E
		public static string GetWorkingPath()
		{
			return Path.Combine("C:\\", Config.WorkingDirectoryName);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003080 File Offset: 0x00001280
		public static void CreateWorkingPath()
		{
			string workingPath = IO.GetWorkingPath();
			if (!Directory.Exists(workingPath))
			{
				Directory.CreateDirectory(workingPath);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000030A2 File Offset: 0x000012A2
		public static string GetLibraryPath()
		{
			return Path.Combine(IO.GetWorkingPath(), Config.LibraryName);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000030B3 File Offset: 0x000012B3
		public static bool IsLibraryFound()
		{
			return File.Exists(IO.GetLibraryPath());
		}
	}
}
