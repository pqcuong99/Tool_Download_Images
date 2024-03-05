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
        public static int GetSumPage(string shopName)
        {
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetLinksSeller(shopName, 0);
            var cvRes = JsonConvert.DeserializeObject<ResponseGetURL_Image>(res);

            var arrLink = cvRes.pageProps.sellerData;
            return arrLink.last_page;
        }
        public static ResponseGetURL_Image GetDataShop(string shopName,int page)
        {
            Api_Custommer api_ = new Api_Custommer();
            string res = api_.GetLinksSeller(shopName, page);
            var cvRes = JsonConvert.DeserializeObject<ResponseGetURL_Image>(res);
            return cvRes;
        }
    }
}
