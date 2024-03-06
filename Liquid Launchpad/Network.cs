using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LiquidLaunchpad
{
	internal class Network
	{
        #region GetUpdatedKey
        public static string GetUpdatedKey()
		{
			string result;
			using (WebClient webClient = new WebClient
			{
				Proxy = null
			})
			{
				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
				result = webClient.DownloadString(Config.ActivationKey);
			}
			return result;
		}
        #endregion

        #region GetUpdatedAssets
        public static bool GetUpdatedAssets()
		{
			try
			{
				string text = Path.Combine(IO.GetWorkingPath(), "Textures.ytd");
				string path = Path.Combine(IO.GetWorkingPath(), "elonmusk.ytd");
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				using (WebClient webClient = new WebClient
				{
					Proxy = null
				})
				{
					webClient.DownloadFile("https://github.com/BiscuiTheHobkin/Liquid/raw/main/Resources/Textures.ytd", text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			return true;
		}
        #endregion

        #region GetUpdatedLibrary
        public static bool GetUpdatedLibrary()
		{
			File.Delete("C:\\Liquid\\Liquid.dll");
			File.Delete("C:\\Liquid\\Liquid.dll");
			using (WebClient webClient = new WebClient
			{
				Proxy = null
			})
			{
				webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537");
				string address = "https://github.com/BiscuiTheHobkin/Liquid/raw/main/Resources/Liquid.dll";
				webClient.DownloadFile(address, IO.GetLibraryPath());
			}
			return true;
		}
        #endregion
    }
}
