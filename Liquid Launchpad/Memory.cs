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
		// Token: 0x0600001D RID: 29
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x0600001E RID: 30
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x0600001F RID: 31
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x06000020 RID: 32
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000021 RID: 33
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x06000022 RID: 34
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x06000023 RID: 35 RVA: 0x000030C7 File Offset: 0x000012C7
		public static bool IsGameRunning()
		{
			return Process.GetProcessesByName(Config.ProcessName).Length != 0;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000030D8 File Offset: 0x000012D8
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

		// Token: 0x04000014 RID: 20
		private const int PROCESS_CREATE_THREAD = 2;

		// Token: 0x04000015 RID: 21
		private const int PROCESS_QUERY_INFORMATION = 1024;

		// Token: 0x04000016 RID: 22
		private const int PROCESS_VM_OPERATION = 8;

		// Token: 0x04000017 RID: 23
		private const int PROCESS_VM_WRITE = 32;

		// Token: 0x04000018 RID: 24
		private const int PROCESS_VM_READ = 16;

		// Token: 0x04000019 RID: 25
		private const uint MEM_COMMIT = 4096U;

		// Token: 0x0400001A RID: 26
		private const uint MEM_RESERVE = 8192U;

		// Token: 0x0400001B RID: 27
		private const uint PAGE_READWRITE = 4U;
	}
}
