using Chilkat;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Download_Image_Inspireuplift.Model.Redbubble;

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
                GetHTML_ID_SHOP_Etsy(shopName);
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
        public String GetHTML_ID_SHOP_Etsy(string shopName)
        {
            try
            {
                Http http = new Http();
                string url = $"https://www.etsy.com/shop/{shopName}";
                
                http.SetRequestHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8");
                http.SetRequestHeader("Sec-Fetch-Dest", "document");
                http.SetRequestHeader("Sec-Fetch-Mode", "navigate");
                http.SetRequestHeader("Sec-Fetch-Site", "none");
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
        public String GetHTML_Image_Redbubble(string shopName, int countItem = 36)
        {
            try
            {
                Variable_redbubble vrb_ = new Variable_redbubble();
                vrb_.operationName = "withSearchResults";
                vrb_.query = "query withSearchResults($query: String!, $queryParams: QueryParams, $locale: String!, $country: String!, $currency: String!, $previewTypeIds: [String!], $experience: String) {\n  searchResults(query: $query, queryParams: $queryParams, locale: $locale, country: $country, currency: $currency, previewTypeIds: $previewTypeIds, experience: $experience) {\n    ...Results\n    ...Metadata\n    ...Filters\n    ...Pagination\n    ...ArtistCollections\n    __typename\n  }\n}\n\nfragment Results on SearchResults {\n  results {\n    inventoryItem(locale: $locale, country: $country, currency: $currency, previewTypeIds: $previewTypeIds) {\n      id\n      marketingProductTypeId\n      description\n      productTypeId\n      productPageUrl\n      blankItemId\n      prominentMessage\n      price {\n        id\n        amount\n        currency\n        discount {\n          amount\n          percent\n          __typename\n        }\n        __typename\n      }\n      previewSet {\n        id\n        previews {\n          previewTypeId\n          url\n          __typename\n        }\n        __typename\n      }\n      gaCode\n      gaCategory\n      attributes {\n        name\n        value\n        attributes {\n          name\n          value\n          __typename\n        }\n        __typename\n      }\n      volumeDiscount {\n        id\n        thresholds {\n          percentOff\n          quantity\n          __typename\n        }\n        __typename\n      }\n      experiencesProductCard {\n        name\n        value\n        __typename\n      }\n      __typename\n    }\n    work(locale: $locale) {\n      id\n      title\n      artistName\n      artistUserName\n      isMatureContent\n      tags\n      __typename\n    }\n    defaultPreviewTypeId\n    groupId\n    rank\n    artistIsEstablished\n    __typename\n  }\n  __typename\n}\n\nfragment Metadata on SearchResults {\n  metadata {\n    title\n    searchContext {\n      category\n      __typename\n    }\n    resultCount\n    topic\n    searchBar {\n      iaCode\n      pillLabel\n      keywords\n      __typename\n    }\n    __typename\n  }\n  __typename\n}\n\nfragment Filters on SearchResults {\n  filters {\n    resetUrl\n    staticFilters {\n      type\n      label\n      options {\n        name\n        label\n        applied\n        url\n        options {\n          name\n          label\n          applied\n          url\n          __typename\n        }\n        __typename\n      }\n      __typename\n    }\n    filters {\n      type\n      label\n      experiences {\n        name\n        value\n        __typename\n      }\n      options {\n        name\n        label\n        applied\n        disabled\n        url\n        hexColor\n        imageUrl\n        __typename\n      }\n      __typename\n    }\n    appliedCount\n    appliedPath\n    resets {\n      label\n      url\n      __typename\n    }\n    __typename\n  }\n  __typename\n}\n\nfragment Pagination on SearchResults {\n  pagination {\n    currentPage\n    perPage\n    showPreviousPageLink\n    showNextPageLink\n    paginationLinks {\n      namedLinks {\n        previousPage {\n          rel\n          url\n          __typename\n        }\n        nextPage {\n          rel\n          url\n          __typename\n        }\n        __typename\n      }\n      __typename\n    }\n    fromNumber\n    toNumber\n    total\n    __typename\n  }\n  __typename\n}\n\nfragment ArtistCollections on SearchResults {\n  artistCollections {\n    applied\n    options {\n      id\n      name\n      label\n      description\n      url\n      imageUrl\n      applied\n      __typename\n    }\n    reset {\n      label\n      description\n      url\n      __typename\n    }\n    type\n    label\n    __typename\n  }\n  __typename\n}\n";
                vrb_.variables =  new Variables();
                vrb_.variables.country = "VN";
                vrb_.variables.currency = "USD";
                vrb_.variables.experience = "artist-shop";
                vrb_.variables.locale = "en";
                vrb_.variables.previewTypeIds = new string[3];
                vrb_.variables.previewTypeIds[0] = "product_close";
                vrb_.variables.previewTypeIds[1] = "alternate_product_close";
                vrb_.variables.previewTypeIds[2] = "artwork";
                vrb_.variables.query = "*";
                vrb_.variables.queryParams = new Queryparams();
                vrb_.variables.queryParams.artistUserName = shopName;
                vrb_.variables.queryParams.pageSize = 100;
                Http http = new Http();
                string url = $"https://www.redbubble.com/people/{shopName}/shop?artistUserName={shopName}";
                
                http.SetRequestHeader("Accept", "*/*");
                //http.SetRequestHeader("X-Nextjs-Data", "1");
                http.SetRequestHeader("Sec-Fetch-Site", "same-origin");
                http.SetRequestHeader("Referer", $"https://www.redbubble.com/people/{shopName}/shop?artistUserName={shopName}&iaCode=all-departments&sortOrder=relevant");
                http.SetRequestHeader("Content-Type", "application/json");
                http.SetRequestHeader("Cookie", "rbVisitorId=01HR6VWX28XHDB2S6X4FMFNWD2; _rb_session=91a98cd413afcc9fc8e493f956b1141c286d586701b71001d7ce98c30441895e; _cfuvid=rku5t1Fm_.VolaSMTtrfKVpdYOaeotJVf.OXxp3UvO0-1709627570027-0.0.1.1-604800000; CookieConsent={stamp:%27-1%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cmethod:%27implied%27%2Cver:1%2Cutc:1709627572438%2Ciab2:%27%27%2Cregion:%27VN%27}; _gcl_au=1.1.895080996.1709627572; gclid=undefined; __attentive_id=82219964b4524f5eba466427c91d57f3; _attn_=eyJ1Ijoie1wiY29cIjoxNzA5NjI3NTcyNTY3LFwidW9cIjoxNzA5NjI3NTcyNTY3LFwibWFcIjoyMTkwMCxcImluXCI6ZmFsc2UsXCJ2YWxcIjpcIjgyMjE5OTY0YjQ1MjRmNWViYTQ2NjQyN2M5MWQ1N2YzXCJ9In0=; __attentive_cco=1709627572568; __pdst=05b944431ae140c2a9682c5eaccb2538; IR_gbd=redbubble.com; FPID=FPID2.2.DMdI4GUkxni6W5u4mtoCCFFYGDPjK8Az4la9ZuQMz4w%3D.1709627572; FPAU=1.2.1405390832.1709627572; IR_PI=c2983d68-a622-11ee-bb9c-6b8fb6e13a27%7C1709713972723; __attentive_dv=1; FPLC=oJQd6O79XbOCI9SGZ3pjq9xKctprYSH1l4GEezHS3K9Io8YzjAkJ4xxc5JKN8FC85PeJm8S6NeVfV0fzsHZIM9cmGm99avELLIIJX%2F2r42LxKiI7duyxBeIm7ly79A%3D%3D; displayBox{266099}=true; displayBox{266099}=true; _gid=GA1.2.1186394945.1709627575; ajs_anonymous_id=1be2e954-1775-4886-91c7-dc4cd9f52705; displayBox{220227}=true; displayBox{220227}=true; _scid=694410ae-998b-484f-2087-43bf0707968d; _fbp=fb.1.1709627581917.1019449408; displayBox{266090}=true; displayBox{266090}=true; __attentive_ss_referrer=https://www.redbubble.com/people/rubyandpearl/shop?artistUserName=rubyandpearl&iaCode=all-stickers; open_id_token=eyJhbGciOiJFUzI1NiIsImtpZCI6InJlZGJ1YmJsZS00IiwidHlwIjoiSldUIn0.eyJhbXIiOlsidW5hdXRoZW50aWNhdGVkIl0sImlzcyI6Imh0dHBzOi8vd3d3LnJlZGJ1YmJsZS5jb20iLCJzdWIiOiJyZWRidWJibGU6MDFIUjZWV1gyOEZCU1czU1RKMFIxR1FGTTkiLCJhdWQiOiJyZWRidWJibGUtc2VydmljZXMiLCJleHAiOjE3MDk2MzEzMjYsImlhdCI6MTcwOTYzMDcyNn0.-WoiaL0VNCijZ3Iq2mkrz_m2yRqYxJK3vBhvm5J_Qk38IWpn59Jn2twxVt7VNgPCuKGufgSkEXOJia5vzI8E7g; __cf_bm=wAjRLX3vhqKroSvksNrCDqiuNfPJBZrVFKoUrPCNtXI-1709630727-1.0.1.1-PVBGWpwXhSqoLQYQ4YNpvYP0R0TVXPoBLquB57u4wk.MjfB15TiI6KuA5tgNU0QAjQ_TvOzQk4JsMPhc6cPXyw; _gat=1; _rb_session4=ZW00R3JZM0M3WVNSNWxSbnZlbXFENWRHMWllam5XM3pmTFhscU9VNXFOV2M2cmlzaW5RSDRGcGFWNDVyaEVTa0ZDZnBYY0NKMk14VEhVazMxMTEvTjY1ZTJXcGN4dnJJNTgyZWIrcnpVSW9iSUxPRVdsYkpVUmZvRlQyQ1V2bVAtLXZ5U2hkKzZJVVhCVW03NUMraTRRYVE9PQ%3D%3D--502649756a283e2cce8a657669bf3b5bad8c8375; _dd_s=; FPGSID=1.1709629661.1709630793.G-QB79Q66SYP.ezOVqfJTuD-5gvl2CK91LQ; _rdt_uuid=1709627572641.b5475685-5e5e-4606-8787-8e00bfa11a7c; _uetsid=f533bb20daca11ee9d2785c8df9ee860; _uetvid=f533fb20daca11eea14565eeb5ab4ca6; IR_11754=1709630796132%7C0%7C1709630796132%7C%7C; __attentive_pv=32; _ga=GA1.2.408166100.1709627572; cto_bundle=1LLbRl80QkJUelBEcWRudUpxZXpiNWg4R3MyRUxrNFNxRk9KSTFGa3g2UmQ2OVlCdlUxNFhSQktuRzlLRmJSR2dMY2FBcEI5TWglMkZaQUN4UjZHN0JLWFV3MVZ4RWVzZ2w1VFBMT1RleGhtVDlEakdIaVZvOWREMDFENkhhSFl1RG9wUWNZdGlmc2k4TWNJd1lzVXRqRHFzWGNYUSUzRCUzRA; _ga_6Y64WETSH7=GS1.1.1709627572.1.1.1709630830.0.0.0; _ga_QB79Q66SYP=GS1.1.1709627572.1.1.1709630835.0.0.0");
                
                Chilkat.HttpResponse httpResponse = http.PostJson("https://www.redbubble.com/boom/graphql",JsonConvert.SerializeObject(vrb_));
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
