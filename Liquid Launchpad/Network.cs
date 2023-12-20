using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	// Token: 0x02000006 RID: 6
	internal class Network
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003014 File Offset: 0x00001214
		public static string GetUpdatedKey()
		{
			string result;
			using (WebClient webClient = new WebClient
			{
				Proxy = null
			})
			{
				result = webClient.DownloadString(Config.ActivationKey);
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003058 File Offset: 0x00001258
		public static bool GetUpdatedAssets()
		{
			try
			{
				string text = Path.Combine(IO.GetWorkingPath(), "Textures.ytd");
				string text2 = Path.Combine(IO.GetWorkingPath(), "elonmusk.ytd");
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
				using (WebClient webClient = new WebClient
				{
					Proxy = null
				})
				{
					webClient.DownloadFile("https://github.com/BiscuiTheHobkin/Liquid/raw/main/Resources/Textures.ytd", text);
					webClient.DownloadFile("https://github.com/BiscuiTheHobkin/Liquid/raw/main/Resources/Liquid.ytd", text2);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			return true;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003104 File Offset: 0x00001304
		public static bool GetUpdatedLibrary()
		{
			try
			{
				if (IO.IsLibraryFound())
				{
					File.Delete(IO.GetLibraryPath());
				}
				using (WebClient webClient = new WebClient
				{
					Proxy = null
				})
				{
					webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
					string address = webClient.DownloadString(Config.LibraryUrl);
					webClient.DownloadFile(address, IO.GetLibraryPath());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			return true;
		}
	}
}
