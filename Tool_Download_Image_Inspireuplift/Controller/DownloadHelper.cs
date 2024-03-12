using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tool_Download_Image_Inspireuplift.Controller
{
    public class DownloadHelper
    {
        public static bool DownloadImage(string url, string pathSave)
        {
            try
            {
                // Get the response from the URL.
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(url), pathSave);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool SaveText(string pathSave , string data)
        {
            try
            {
                if (!File.Exists(pathSave))
                {
                    // Nếu không tồn tại, tạo tập tin mới
                    using (StreamWriter sw = File.CreateText(pathSave))
                    {
                        sw.Write(data);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(pathSave))
                    {
                        sw.Write(data);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static string CreateFolder(string pathSave, string nameFolder)
        {
            try
            {
                pathSave = pathSave + "\\"+ nameFolder;

                if (!Directory.Exists(pathSave))
                {
                    // Create the folder.
                    Directory.CreateDirectory(pathSave);
                }

                return pathSave;
            }
            catch (Exception e)
            {
                return pathSave;
            }
        }

    }
}
