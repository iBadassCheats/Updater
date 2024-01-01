using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace __Update__
{
    internal class Settings
    {
        public static string Pathname = "C:\\HelperTools";
        public static string Filename { get; set; } = "randomly.exe";

        public static string RandomString(int length = 32, bool stringornumber = true)
        {
            Random random = new Random();
            string chars = "";
            if (stringornumber)
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            }
            else
            {
                chars = "0123456789";
            }
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void DownloadFile(string file_name)
        {
            using (var wc = new WebClient())
            {
                try
                {
                    if (!Directory.Exists(Pathname))
                    {
                        Directory.CreateDirectory(Pathname);
                    }
                    else
                    {
                        Directory.GetFiles(Pathname + "\\", "*.exe").ToList().ForEach(f => File.Delete(f));
                        Thread.Sleep(500);

                        wc.DownloadFile("/your website/" + file_name, Pathname + "\\" + Filename);
                        Thread.Sleep(2000);

                        Process process = new Process();
                        process.StartInfo = new ProcessStartInfo(Pathname + "\\" + Filename);
                        process.EnableRaisingEvents = true;
                        process.Start();

                        Thread.Sleep(1500);
                        Environment.Exit(-1);
                    }
                }
                catch (WebException)
                {
                    MessageBox.Show("File not Exits or its not yet Updated");
                    return;
                }
                catch
                {
                    MessageBox.Show("Error Download");
                    return;
                }
            }
        }
    }
}
