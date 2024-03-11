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
        public String GetLinksSeller(string shopName, int pageNumber,string keyRequest)
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.inspireuplift.com/_next/data/{keyRequest}/shop/{shopName}.json?sort=most_recent&country=%3Acountry&sellerSlug={shopName}";
                if (pageNumber > 1)
                {
                    url = $"https://www.inspireuplift.com/_next/data/{keyRequest}/shop/{shopName}.json?page={pageNumber}&sort=most_recent&country=%3Acountry&sellerSlug={shopName}";

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
        public String GetKeysInsprice(string shopName)
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.inspireuplift.com/shop/{shopName}";
                
                http.SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Sec-Fetch-Dest", "document");
                http.SetRequestHeader("Sec-Fetch-Mode", "navigate");
                http.SetRequestHeader("Sec-Fetch-Site", "none");
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

        public String GetHTML_Image_Etsy(string shopName, int countItem = 36, string idShop = "", string sesion_id = "")
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.etsy.com/api/v3/ajax/bespoke/member/shops/{idShop}/listings-view?limit=36&offset={countItem}&sort_order=date_desc&path=%2Fshop%2F{shopName}&is_edit=false&on_sale_only=false&wider_shop_home_v2=true&should_show_sticky_nav=true&is_paginated_recs_relevance=false";
               if(sesion_id != "")
                {
                    url = $"https://www.etsy.com/api/v3/ajax/bespoke/member/shops/{idShop}/listings-view?section_id={sesion_id}&limit=36&offset={countItem}&sort_order=date_desc&path=%2Fshop%2F{shopName}&is_edit=false&on_sale_only=false&wider_shop_home_v2=true&should_show_sticky_nav=true&is_paginated_recs_relevance=false";
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
        public String GetHTML_ID_Shop_Etsy(string shopName)
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.etsy.com/shop/{shopName}?ref=l2-about-shopname";
                
                http.SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Sec-Fetch-Dest", "document");
                http.SetRequestHeader("Sec-Fetch-Mode", "navigate");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Cookie", "uaid=t_PgLsLZqgfSxvDPGh_bkRMEWiVjZACC1Mcyf2F0tVJpYmaKkpVSWaBBRkiBd5pbUXFIlblRoF9VeVKRl5Nurpl_mlItAwA.; user_prefs=XPIMuFmAdXPkykS9Lp5IEz5rzH9jZACC1Mcyf2F0tFKYn4uSTl5pTo6OUmqebmiwkg5QCCpiBKFwEbEMAA..; fve=1709382909.0; _fbp=fb.1.1709382909215.8753438379493829; exp_ebid=m=VYrGZieUs0wxUN%2BVOMYblCZYTmNDpjvUDRZfeiRgows%3D,v=JaHZWZwzGo2VKYTQ2Ku3DP6EsgvIOKEc; ua=531227642bc86f3b5fd7103a0c0b4fd6; _gcl_au=1.1.1336973265.1709382912; _ga=GA1.1.750836272.1709382912; lantern=7cdbd9ba-b80a-49fd-921e-ce49baea4ce0; _pin_unauth=dWlkPU1HWXhNekV3TW1RdE1HUmpaaTAwTXpoaExXRXlOV1l0T1RCaE5qRmxZbVUxWkdJMw; wedding_session=yRqLmF-kHnjTGuWF3GabB3fK6bJjZACC1MeyMnAaAA..; hs_listing_views=UZqyfDYRziZMLsCu33wiOCaR3yNjZACC1MeK7VC6v1rJ0MjcwNzYwtjUUsnKqJYBAA..; __pdst=48a1d6a64839478babd24200cc6b3993; _tt_enable_cookie=1; _ttp=LNkgOnwjf4OuMXwrlEhFoMvwcnl; last_browse_page=https%3A%2F%2Fwww.etsy.com%2Fshop%2FTheTStoreDesign; _ga_KR3J610VYM=GS1.1.1709734072.9.1.1709734121.11.0.0; _uetsid=ebfdb1e0dbc211eeb1dfd3f2815178d9; _uetvid=50658800d89111ee826b6137c3beff35; datadome=vtqrsdkvRnm2wWlVzrJ0GctJDXyNmT_06R2xs5jrESQqgWyszbQnibmtZuBPv6ENu5deJh4t7ASO9_SXctGtf6ua1CmB7kGLQfXGOLcGr3BKG7F~_2oQhSXswIheoaN3");
                http.SetRequestHeader("Referer", $"https://www.etsy.com/shop/{shopName}");
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
