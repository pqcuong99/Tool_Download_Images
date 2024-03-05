using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Model
{
    public class ResponseGetURL_Image
    {
        public Pageprops pageProps { get; set; }
        public bool __N_SSP { get; set; }
    }

    public class Pageprops
    {
        public string sellerSlug { get; set; }
        public Shop shop { get; set; }
        public bool status { get; set; }
        public int pageNo { get; set; }
        public Sellerdata sellerData { get; set; }
        public Reviews reviews { get; set; }
        public string path { get; set; }
        public bool isBot { get; set; }
        public bool isLoggedIn { get; set; }
        public Localization localization { get; set; }
    }

    public class Shop
    {
        public int id { get; set; }
        public string shop_name { get; set; }
        public Logo logo { get; set; }
        public Cover cover { get; set; }
        public Profile profile { get; set; }
        public string about { get; set; }
        public string return_policy { get; set; }
        public string faq { get; set; }
        public string shop_announcement { get; set; }
        public object rating { get; set; }
        public object rating_count { get; set; }
        public string seo_title { get; set; }
        public string seo_description { get; set; }
        public int _return { get; set; }
        public object sale_limit { get; set; }
        public string deliver_to { get; set; }
        public string slug { get; set; }
        public int is_active { get; set; }
        public int seller_group_id { get; set; }
        public int is_excel_exported { get; set; }
        public int total_orders { get; set; }
        public DateTime created_at { get; set; }
        public int seller_product_count { get; set; }
        public int seller_follower_count { get; set; }
        public Feature_Products feature_products { get; set; }
        public Collection[] collections { get; set; }
        public bool vacation_mode { get; set; }
        public int reviewit_store_id { get; set; }
    }

    public class Logo
    {
        public string url { get; set; }
    }

    public class Cover
    {
        public string url { get; set; }
    }

    public class Profile
    {
        public string url { get; set; }
    }

    public class Feature_Products
    {
        public int current_page { get; set; }
        public Datum[] data { get; set; }
        public string first_page_url { get; set; }
        public int from { get; set; }
        public int last_page { get; set; }
        public string last_page_url { get; set; }
        public Link[] links { get; set; }
        public object next_page_url { get; set; }
        public string path { get; set; }
        public int per_page { get; set; }
        public object prev_page_url { get; set; }
        public int to { get; set; }
        public int total { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string compare_at_price { get; set; }
        public string slug { get; set; }
        public object rating { get; set; }
        public object rating_count { get; set; }
        public string vendor { get; set; }
        public string url { get; set; }
        public Featured_Image featured_image { get; set; }
        public object campaign { get; set; }
        public object promotion { get; set; }
    }

    public class Featured_Image
    {
        public int id { get; set; }
        public string url { get; set; }
        public string alt { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string label { get; set; }
        public bool active { get; set; }
    }

    public class Collection
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class Sellerdata
    {
        public string current_page { get; set; }
        public Datum1[] data { get; set; }
        public string first_page_url { get; set; }
        public int last_page { get; set; }
        public string last_page_url { get; set; }
        public string next_page_url { get; set; }
        public int per_page { get; set; }
        public object prev_page_url { get; set; }
        public int total { get; set; }
    }

    public class Datum1
    {
        public int id { get; set; }
        public string title { get; set; }
        public string compare_at_price { get; set; }
        public string price { get; set; }
        public int rating { get; set; }
        public object rating_count { get; set; }
        public int seller_id { get; set; }
        public Shop1 shop { get; set; }
        public string slug { get; set; }
        public Featured_Image1 featured_image { get; set; }
        public string url { get; set; }
        public object campaign { get; set; }
        public object promotion { get; set; }
    }

    public class Shop1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Featured_Image1
    {
        public int id { get; set; }
        public string alt { get; set; }
        public string url { get; set; }
    }

    public class Reviews
    {
        public int total_reviews { get; set; }
        public int avg_rating { get; set; }
        public Grp_Rating[] grp_rating { get; set; }
        public bool status { get; set; }
    }

    public class Grp_Rating
    {
        public int rating { get; set; }
        public int count { get; set; }
    }

    public class Localization
    {
        public bool cookieExist { get; set; }
        public string IULOCAL { get; set; }
    }

}
