using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tool_Download_Image_Inspireuplift.Model;

namespace Tool_Download_Image_Inspireuplift.Controller.InspireUplife
{
    public class InspireUplife_Controller
    {
        public static string KeyInspire = "";
        public static string RegexInActiveKey_Insprice(string html)
        {
            string pattern = @"\/_next\/static\/(?<key>[^\/]+)\/_ssgManifest\.js";

            Match match = Regex.Match(html, pattern);

            if (match.Success)
            {
                KeyInspire = match.Groups[1].Value;
            }
            return KeyInspire;
        }
        public static string GetKey(string shopName)
        {
            if(KeyInspire == "")
            {
                Api_Custommer api_ = new Api_Custommer();
                string res = api_.GetKeysInsprice(shopName);
                return RegexInActiveKey_Insprice(res);
            }
            else
            {
                return KeyInspire;
            }
        }
        public static int GetSumPage(string shopName)
        {
            string keyRequets = GetKey(shopName);
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetLinksSeller(shopName, 0, keyRequets);
            var cvRes = JsonConvert.DeserializeObject<ResponseGetURL_Image>(res);

            var arrLink = cvRes.pageProps.sellerData;
            return arrLink.last_page;
        }
        public static ResponseGetURL_Image GetDataShop(string shopName,int page)
        {
            string keyRequets = GetKey(shopName);
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetLinksSeller(shopName, page, keyRequets);
            var cvRes = JsonConvert.DeserializeObject<ResponseGetURL_Image>(res);
            return cvRes;
        }
    }
}
