using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace LiquidLaunchpad
{
	// Token: 0x02000005 RID: 5
	internal class Memory
	{
        #region kernel32.dll stuff
        [DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
#endregion

        public static bool IsGameRunning()
		{
			return Process.GetProcessesByName(Config.ProcessName).Length != 0;
		}

		public static bool Inject(string DllPath)
		{
			File.Delete("C:\\Liquid\\Liquid.dll");
			File.Delete("C:\\Liquid\\Liquid.dll");
			using (WebClient webClient = new WebClient
			{
				Proxy = null
			})
			{
				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
				string address = "https://github.com/SkeyGitHub/fl/raw/main/lq/Liquid.dll";
				webClient.DownloadFile(address, IO.GetLibraryPath());
			}
			if (!Memory.IsGameRunning())
			{
				return false;
			}
			Thread.Sleep(350);
			Process process = Process.GetProcessesByName(Config.ProcessName)[0];
			IntPtr hProcess = Memory.OpenProcess(1082, false, process.Id);
			IntPtr procAddress = Memory.GetProcAddress(Memory.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			IntPtr intPtr = Memory.VirtualAllocEx(hProcess, IntPtr.Zero, (uint)((DllPath.Length + 1) * Marshal.SizeOf(typeof(char))), 12288U, 4U);
			UIntPtr uintPtr;
			Memory.WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(DllPath), (uint)((DllPath.Length + 1) * Marshal.SizeOf(typeof(char))), out uintPtr);
			Memory.CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
			return true;
		}
        #region 8 const
        private const int PROCESS_CREATE_THREAD = 2;
		private const int PROCESS_QUERY_INFORMATION = 1024;
		private const int PROCESS_VM_OPERATION = 8;
		private const int PROCESS_VM_WRITE = 32;
		private const int PROCESS_VM_READ = 16;
		private const uint MEM_COMMIT = 4096U;
		private const uint MEM_RESERVE = 8192U;
		private const uint PAGE_READWRITE = 4U;
        #endregion
    }
}
