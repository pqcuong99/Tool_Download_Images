using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Controller
{
    public class RegistryHelper
    {
        public static bool SaveIntValue(string subKey, string valueName, int data)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(subKey))
            {
                if (key != null)
                {
                    key.SetValue(valueName, data);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Hàm để lấy ra dữ liệu kiểu int từ Registry
        public static int GetIntValue(string subKey, string valueName, int defaultValue = 0)
        {
            int result = defaultValue;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(subKey))
            {
                if (key != null)
                {
                    var value = key.GetValue(valueName);
                    if (value != null)
                    {
                        int.TryParse(value.ToString(), out result);
                    }
                }
                else
                {
                    return -999;
                }
            }

            return result;
        }
    }
}
