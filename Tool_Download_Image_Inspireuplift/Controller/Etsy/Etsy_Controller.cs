using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tool_Download_Image_Inspireuplift.Model.Etsy;
using xNet;

namespace Tool_Download_Image_Inspireuplift.Controller.Etsy
{
    public class Etsy_Controller
    {
        public static int countItems = 0;
        public static string dataLV = "";
        public static List<Variable_Data_Image_GetHTML> GetListUrls_Etsy(string nameShop, int cout = 0, string idShop = "")
        {
            dataLV = "";
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetHTML_Image_Etsy(nameShop, cout, idShop);
            var cv = JsonConvert.DeserializeObject<Response_Etsy_GetHtml>(res);
            countItems = Int32.Parse(cv.total_count);

            List<Variable_Data_Image_GetHTML> listData = Etsy_Controller.ExtractRegex_Data_Esty_HTML(cv.html);
            return listData;
        }
        public static List<Variable_Data_Image_GetHTML> GetListUrls_Etsy_Section_id(string nameShop, int cout = 0, string idShop = "", string section_id = "")
        {
            dataLV = "";
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetHTML_Image_Etsy(nameShop, cout, idShop, section_id);
            var cv = JsonConvert.DeserializeObject<Response_Etsy_GetHtml>(res);
            countItems = Int32.Parse(cv.total_count);

            List<Variable_Data_Image_GetHTML> listData = Etsy_Controller.ExtractRegex_Data_Esty_HTML(cv.html);
            return listData;
        }
        public static List<Variable_Data_Image_GetHTML> ExtractRegex_Data_Esty_HTML(string text)
        {
            string pattern = @"<div[^>]+?class=""placeholder-content[^>]+?"
                             + @">((?:.|\n|\r)+?)</div>"; // Optimized pattern

            var matches = Regex.Matches(text, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase);
            var extractedContent = new List<Variable_Data_Image_GetHTML>();

            foreach (Match match in matches)
            {
                // Extract the content group (group 1) and trim potential whitespace
                string content = match.Groups[1].Value.Trim();
                Variable_Data_Image_GetHTML variable_Data = new Variable_Data_Image_GetHTML();

                variable_Data.url = GetUrlImages(content);
                variable_Data.tittle = GetTittleImages(content);
                dataLV += variable_Data.url + "\n";
                extractedContent.Add(variable_Data);
            }
            return extractedContent;
        }
        public static string GetUrlImages(string text)
        {
            const string pattern = @"srcset=""([^""]+?)"""; // Optimized pattern

            var match = Regex.Match(text, pattern);

            if (match.Success)
            {
                if (match.Groups[1].Value.Split(',').Length > 1)
                {
                    string textSplit = match.Groups[1].Value.Split(',')[match.Groups[1].Value.Split(',').Length - 1].Trim();
                    if (textSplit.Split(' ').Length > 1)
                    {
                        return textSplit.Split(' ')[0];
                    }
                    else
                    {
                        return textSplit;
                    }
                }
                return match.Groups[1].Value; // Extract the content group (group 1)
            }
            else
            {
                return string.Empty; // Return empty string if no match found
            }
        }
        public static string GetTittleImages(string text)
        {
            const string pattern = @"alt=""([^""]+?)"""; // Optimized pattern

            var match = Regex.Match(text, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value; // Extract the content group (group 1)
            }
            else
            {
                return string.Empty; // Return empty string if no match found
            }
        }
        public static string RegexId_Shop_Etsy(string text)
        {
            const string pattern = @"data-shop-id=""(\d+)"""; // Optimized pattern

            var match = Regex.Match(text, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value; // Extract the content group (group 1)
            }
            else
            {
                return string.Empty; // Return empty string if no match found
            }
        }
        public static string Get_ID_shop_Etsy(string nameShop)
        {
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetHTML_ID_Shop_Etsy(nameShop);
            string id = RegexId_Shop_Etsy(res);
            return id;
        }
        public static int pageTotal()
        {
            return countItems / 36;
        }
        public static void resetCountItems()
        {
            countItems = 0;
        }
    }

}
