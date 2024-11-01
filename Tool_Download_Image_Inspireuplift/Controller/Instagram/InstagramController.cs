using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using Tool_Download_Image_Inspireuplift.Model.Instagram;

namespace Tool_Download_Image_Inspireuplift.Controller.Instagram
{
    public class InstagramController
    {
        public static bool GetDataUser(string username,string cursor = null,string pathSave = null)
        {
            try
            {
                Api_Custommer api_ = new Api_Custommer();
                string res = api_.GetDataProfile_Instagram(username, cursor);
                ResponseDataInstagram data = JsonConvert.DeserializeObject<ResponseDataInstagram>(res);

                string cursorNext = data.data.xdt_api__v1__feed__user_timeline_graphql_connection.page_info.end_cursor;
                bool isNext = data.data.xdt_api__v1__feed__user_timeline_graphql_connection.page_info.has_next_page;
                Edge[] dataPost = data.data.xdt_api__v1__feed__user_timeline_graphql_connection.edges;
                DownloadImaePost(dataPost, pathSave);
                while (isNext) {
                    res = api_.GetDataProfile_Instagram(username, cursorNext);
                    data = JsonConvert.DeserializeObject<ResponseDataInstagram>(res);
                    cursorNext = data.data.xdt_api__v1__feed__user_timeline_graphql_connection.page_info.end_cursor;
                    isNext = data.data.xdt_api__v1__feed__user_timeline_graphql_connection.page_info.has_next_page;
                    dataPost = data.data.xdt_api__v1__feed__user_timeline_graphql_connection.edges;
                    DownloadImaePost(dataPost, pathSave);
                }
                return true;
            }
            catch (Exception ex) { 
                return false;
            }
        }
        public static void DownloadImaePost(Edge[] edges,string pathSave)
        {
            foreach (Edge edge in edges) {
                if(edge.node.carousel_media == null)
                {
                    continue;
                }
                foreach (Carousel_Media media in edge.node.carousel_media) {
                    TimeSpan myDateResult = DateTime.Now.TimeOfDay;
                    string timeSpan_tostring = myDateResult.Ticks.ToString();

                    string path_ = pathSave + $"\\{timeSpan_tostring}.png";
                    DownloadHelper.DownloadImage(media.image_versions2.candidates[0].url, path_);
                }
            }
        }
        public static string RegexShopName(string url)
        {
            string shopName = "";
            string pattern = @"(?:instagram.com\/)([^?]+)";

            Match match = Regex.Match(url, pattern);

            if (match.Success)
            {
                shopName = match.Groups[1].Value;
            }
            if (shopName.Split('/').Length > 1)
            {
                shopName = shopName.Split('/')[0];
            }
            return shopName;
        }
    }
}
