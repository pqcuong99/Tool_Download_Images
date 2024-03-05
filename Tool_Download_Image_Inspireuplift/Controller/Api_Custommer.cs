using Chilkat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Controller
{
    public class Api_Custommer
    {
        public String GetLinksSeller(string shopName,int pageNumber)
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.inspireuplift.com/_next/data/Vzh2fO9zA48_tzs8JIkJz/shop/{shopName}.json?sort=most_recent&country=%3Acountry&sellerSlug={shopName}";
                if(pageNumber > 1)
                {
                    url = $"https://www.inspireuplift.com/_next/data/Vzh2fO9zA48_tzs8JIkJz/shop/{shopName}.json?page={pageNumber}&sort=most_recent&country=%3Acountry&sellerSlug={shopName}";

                }
                http.SetRequestHeader("Accept", "*/*");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Referer", $"https://www.inspireuplift.com/shop/{shopName}?sort=relevant");
                //http.SetRequestHeader("Accept-Encoding", "gzip, deflate, br, zstd");
                Chilkat.HttpResponse httpResponse = http.QuickGetObj(url);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String GetHTML_Image_Etsy(string shopName, int countItem = 36,string sesion_id = "")
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.etsy.com/api/v3/ajax/bespoke/member/shops/40050336/listings-view?limit=36&offset={countItem}&sort_order=date_desc&path=%2Fshop%2F{shopName}&is_edit=false&on_sale_only=false&wider_shop_home_v2=true&should_show_sticky_nav=true&is_paginated_recs_relevance=false";
               if(sesion_id != "")
                {
                    url = $"https://www.etsy.com/api/v3/ajax/bespoke/member/shops/40050336/listings-view?section_id={sesion_id}&limit=36&offset={countItem}&sort_order=date_desc&path=%2Fshop%2F{shopName}&is_edit=false&on_sale_only=false&wider_shop_home_v2=true&should_show_sticky_nav=true&is_paginated_recs_relevance=false";
                }
                http.SetRequestHeader("Accept", "*/*");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Referer", $"https://www.etsy.com/shop");
                //http.SetRequestHeader("Accept-Encoding", "gzip, deflate, br, zstd");
                Chilkat.HttpResponse httpResponse = http.QuickGetObj(url);
                if (httpResponse == null)
                {
                    throw new Exception("Error Request: " + httpResponse);
                }
                //return httpResponse;
                return httpResponse.BodyStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
