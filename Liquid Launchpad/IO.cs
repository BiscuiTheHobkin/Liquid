using System;
using System.IO;

namespace LiquidLaunchpad
{
	internal class IO
	{
        #region GetWorkingPath
        public static string GetWorkingPath()
		{
			return Path.Combine("C:\\", Config.WorkingDirectoryName);
		}
        #endregion

        #region CreateWorkingPath
        public static void CreateWorkingPath()
		{
			string workingPath = IO.GetWorkingPath();
			if (!Directory.Exists(workingPath))
			{
				Directory.CreateDirectory(workingPath);
			}
		}
        #endregion

        #region GetLibraryPath
        public static string GetLibraryPath()
		{
			return Path.Combine(IO.GetWorkingPath(), Config.LibraryName);
		}
        #endregion

        #region IsLibraryFound
        public static bool IsLibraryFound()
		{
			return File.Exists(IO.GetLibraryPath());
		}
        #endregion
    }
}
