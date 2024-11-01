using Chilkat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Tool_Download_Image_Inspireuplift.Model.Instagram;

namespace Tool_Download_Image_Inspireuplift.Controller
{
    public class Api_Custommer
    {
        public String GetLinksSeller(string shopName, int pageNumber, string keyRequest)
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
                if (sesion_id != "")
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
        public string GetID_User_Instargram(string user_name)
        {
            try
            {
                Chilkat.Http http = new Chilkat.Http();
                string url = $"https://www.instagram.com/api/v1/users/web_profile_info/?username={user_name}";

                http.SetRequestHeader("Accept", "*/*");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Referer", $"https://www.instagram.com/{user_name}/reels/");
                http.SetRequestHeader("Viewport-Width", "1109");
                http.SetRequestHeader("X-Asbd-Id", "129477");
                http.SetRequestHeader("X-Csrftoken", "AFKEnII1VHrdg1SSXfCS40vq6FtgR9uq");
                http.SetRequestHeader("X-Ig-App-Id", "936619743392459");
                http.SetRequestHeader("Cookie", "mid=ZavGTQALAAF59aA8q-xWUPGbd49n; ig_did=1A79E71D-504B-4DF0-B06A-20063A1F3D93; datr=TcarZWZRKXfc0oe1nvGoSdF4; fbm_124024574287414=base_domain=.instagram.com; ig_nrcb=1; ps_l=0; ps_n=0; csrftoken=AFKEnII1VHrdg1SSXfCS40vq6FtgR9uq; ds_user_id=9388035662; shbid=\"8894\\0549388035662\\0541740924700:01f76b37a361a51c6d0f733d9759ee1d698e9e1c8b58bacf1efec107f5cc021a8d55e303\"; shbts=\"1709388700\\0549388035662\\0541740924700:01f7bf60c0f36193ea135813dcca312e09e531731f1647e00f3877714ad6b877193acce4\"; sessionid=9388035662%3A5yoOSwee8Ticqa%3A10%3AAYek-Rm_O3Ivwy2Up2H6sMtduAWl7r3HCCIiShFzbw; rur=\"FRC\\0549388035662\\0541740924739:01f7ba493172602f92ef3026478543e25c7abb224011ee251a4b1687827ac2dd8d0e31b5\"; fbsr_124024574287414=JNQixnlp4r8VGa1CCefM-ZbhJ8zrkWlSjmmxQiJCo7U.eyJ1c2VyX2lkIjoiMTAwMDE3MDI5MDU5ODU4IiwiY29kZSI6IkFRQnBOR3RHUEF2eGwydlRYR0R4bmR3LXVkWktHZ3JNQVdfYzgtQk0zY253clBYRFNoVm9vMzhKY21wM1I4aGhLemd4MDE3bTVZZ1ltdk1zLXdoMDRXc0FxZEhnbm1qN3MzWnpXcmlJZm9BLVpJMmpzMGlqRUlsc09XSHBNUVdMS0RSd0JHcnhhVDktX0RZQXZDVUlJYlcwR1BES3QyQ256TjVyR2x0dmctREdnaXh1YkZkS3RvUFFaZ0M0M0l5Sm5tLXBTazg5VFN5WVVNWkFoVDY3Z25udGhRaU1YUDRlanJtWjI5dm03aVNYcGV2bzl1VFlEcWZKeG9LZlp1QkFCQVRMTDVGSDhxQkNtZWtXOWtOSklzTG01alVSWjhiQUlDRk1uZVR2ZmduSkM2RTJmc3RMeVdKM2xKUDB2ZjEzcERmcG9hYXdvMGp6MTJ5LS1uaVBGYmxBX05POHc5NHNmSXBXbHg5ZHFlRFJEZyIsIm9hdXRoX3Rva2VuIjoiRUFBQnd6TGl4bmpZQk82Sm1HUGhaQlg1eDNTc2FDSlpCTTBaQjR0OU9INWU0TEY5ZHJpRjFtNUVsY2tsem92TTF2elpBcjhOVktaQ0FXVno4b1pCcVh1UHBlWkNYZEx5NEVGUVZLM1ZmSjJ1NUJub0VjSG9yTUk1MHZzTVhmdnlUMlB2bTl0dkgzM1k1YzlaQzRmNlZaQnhFdE8wSWNsQXVxdDJLYXVEOGFSaTJmYWV0aGJaQVpCVGt6VmFaQlVkYXBsRjN3U0M1a2ZvWkQiLCJhbGdvcml0aG0iOiJITUFDLVNIQTI1NiIsImlzc3VlZF9hdCI6MTcwOTM5ODgzMn0");
                http.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
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
        public string GetDataProfile_Instagram(string user_name,string cursor = null)
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.instagram.com/graphql/query";

                http.SetRequestHeader("accept", "*/*");
                http.SetRequestHeader("accept-language", "en,vi;q=0.9,vi-VN;q=0.8,fr-FR;q=0.7,fr;q=0.6,en-US;q=0.5,zh-CN;q=0.4,zh;q=0.3");
                http.SetRequestHeader("content-type", "application/x-www-form-urlencoded");
                http.SetRequestHeader("cookie", "datr=BNQjZzuWbVgLYQ9uNjgmS22P; ig_did=9548DCD9-DC26-4D68-A2DA-4B7A55E41F2E; ps_l=1; ps_n=1; mid=ZyPUBAALAAG5Px53rLRg3FzCaPj9; ig_nrcb=1; csrftoken=Jd2UbOF7sp1yXRRyT4MrFFzSCwUqYcOq; ds_user_id=9388035662; sessionid=9388035662%3A4rAu7RZR2l2NOz%3A18%3AAYcFZW7jwfNLNXiY_tz9Lx5rJYAB3jS2JyjWmrZH8w; wd=1365x929; rur=\"HIL\\0549388035662\\0541761942305:01f7a6a488fe005f7ef0f30522a6c2a34f3d0e551162248837a2ed67c7ec1f466c8fa35c\"; csrftoken=Jd2UbOF7sp1yXRRyT4MrFFzSCwUqYcOq; ds_user_id=9388035662; rur=\"HIL\\0549388035662\\0541761942682:01f7c93e6af1c84b3a6e95ac461307cebb17b548b4d36ea6c6ecffb0ca49a47cc3d123d7\"");
                http.SetRequestHeader("origin", "https://www.instagram.com");
                http.SetRequestHeader("priority", "u=1, i");
                http.SetRequestHeader("referer", $"https://www.instagram.com/{user_name}/");
                http.SetRequestHeader("sec-ch-prefers-color-scheme", "light");
                http.SetRequestHeader("sec-ch-ua", "\"Chromium\";v=\"130\", \"Google Chrome\";v=\"130\", \"Not?A_Brand\";v=\"99\"");
                http.SetRequestHeader("sec-ch-ua-full-version-list", "\"Chromium\";v=\"130.0.6723.70\", \"Google Chrome\";v=\"130.0.6723.70\", \"Not?A_Brand\";v=\"99.0.0.0\"");
                http.SetRequestHeader("sec-ch-ua-mobile", "?0");
                http.SetRequestHeader("sec-ch-ua-model", "\"\"");
                http.SetRequestHeader("sec-ch-ua-platform", "\"Windows\"");
                http.SetRequestHeader("sec-ch-ua-platform-version", "\"10.0.0\"");
                http.SetRequestHeader("sec-fetch-dest", "empty");
                http.SetRequestHeader("sec-fetch-mode", "cors");
                http.SetRequestHeader("sec-fetch-site", "same-origin");
                http.SetRequestHeader("x-asbd-id", "129477");
                http.SetRequestHeader("x-bloks-version-id", "a2e134f798301e28e517956976df910b8fa9c85f9187c2963f77cdd733f46130");
                http.SetRequestHeader("x-csrftoken", "Jd2UbOF7sp1yXRRyT4MrFFzSCwUqYcOq");
                http.SetRequestHeader("x-fb-friendly-name", "PolarisFeedTimelineRootV2Query");
                http.SetRequestHeader("x-fb-lsd", "_jOeARqRjbJPG06DLfM8Nv");
                http.SetRequestHeader("x-ig-app-id", "936619743392459");

                string variablesJson = "";
                if(cursor == null)
                {
                    Variable variable = new Variable();
                    variable.data = new Data();
                    variable.data.count = 10;
                    variable.data.include_relationship_info = true;
                    variable.data.latest_besties_reel_media = true;
                    variable.data.latest_reel_media = true;

                    variable.username = user_name;
                    variable.__relay_internal__pv__PolarisIsLoggedInrelayprovider = true;
                    variable.__relay_internal__pv__PolarisFeedShareMenurelayprovider = true;

                    variablesJson = JsonConvert.SerializeObject(variable);
                }
                else
                {
                    Variables variables = new Variables();
                    variables.after = cursor;
                    variables.before = null;
                    variables.first = 10;
                    variables.last = 10;
                    variables.username = user_name;
                    variables.__relay_internal__pv__PolarisIsLoggedInrelayprovider = true;
                    variables.__relay_internal__pv__PolarisFeedShareMenurelayprovider = true;

                    variables.data = new Datas();
                    variables.data.count = 10;
                    variables.data.include_relationship_info = true;
                    variables.data.latest_besties_reel_media = true;
                    variables.data.latest_reel_media = true;

                    variablesJson = JsonConvert.SerializeObject(variables);
                }

                var postData = new Dictionary<string, string>
                {
                    { "av", "17841409469863504" },
                    { "__d", "www" },
                    { "__user", "0" },
                    { "__a", "1" },
                    { "__req", "7" },
                    { "__hs", "20027.HYP:instagram_web_pkg.2.1..0.1" },
                    { "dpr", "1" },
                    { "__ccg", "UNKNOWN" },
                    { "__rev", "1017844054" },
                    { "__s", "fkziyy:j2u5cc:opptv8" },
                    { "__hsi", "7432046517694841384" },
                    { "__dyn", "7xeUjG1mxu1syUbFp41twpUnwgU7SbzEdF8aUco2qwJxS0k24o1DU2_CwjE1EE2Cw8G11wBz81s8hwGxu786a3a1YwBgao6C0Mo2swtUd8-U2zxe2GewGw9a361qw8Xxm16wUwtEvw5rCwLyESE7i3vwDwHg2ZwrUdUbGwmk0zU8oC1Iwqo5q3e3zhA6bwIxe6V8aUuwm9EO6UaU3cG8BK4oqw" },
                    { "__csr", "gF6MH2q2tkKzMxflqQJkFdnHGl9qRqFZZ9bFqFqCLGWjBKjiAqDbBVqyGihWXmCAAjBGepFUG9AmF6ESgxbyFBy9vCBV94nu4Q5aBGnzUkAyKdDy8ynyuqa_x64K8LjiJ-FQ6QWKFdu2u4oOex3y5F162miU89U01eDoK0Ck5XhqwdKlzA0-8iw2WFEC4Ejwoo1vo0jjw4dw2NoQw0L96h8hm4hm1ewsIwlwoE4-4-iEb41Bg88mw9FpJ5wjKrP0wpAS20h44au1Nwn8iwcS365Q3B6DQ0va1vxi0eZ4iy806VS0nC" },
                    { "__comet_req", "7" },
                    { "fb_dtsg", "NAcOrwoO0xgAhfDb5ImWDZgl41TCgJX-zzSX_fm0bqAwMSYLnt2UeBw:17853828322093762:1730401296" },
                    { "jazoest", "26362" },
                    { "lsd", "DVjtPD8cZ1xCg-_LsEh8n9" },
                    { "__spin_r", "1017844054" },
                    { "__spin_b", "trunk" },
                    { "__spin_t", "1730408174" },
                    { "fb_api_caller_class", "RelayModern" },
                    { "fb_api_req_friendly_name", "PolarisProfilePostsQuery" },
                    { "variables", variablesJson },
                    { "server_timestamps", "true" },
                    { "doc_id", "8633614153419931" }
                };
                HttpRequest request = new HttpRequest();
                foreach (var kvp in postData)
                {
                    request.AddParam(kvp.Key, kvp.Value);
                }
                //http.SetRequestHeader("Accept-Encoding", "gzip, deflate, br, zstd");
                HttpResponse httpResponse = http.PostUrlEncoded("https://www.instagram.com/graphql/query", request);
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
