using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Model.Etsy
{

    public class Response_Etsy_GetHtml
    {
        public string total_count { get; set; }
        public int returned_count { get; set; }
        public int count_including_offset { get; set; }
        public string sort_order { get; set; }
        public string html { get; set; }
        public string header_html { get; set; }
        public string pagination_html { get; set; }
    }
    public class Variable_Data_Image_GetHTML
    {
        public string url { get; set; }
        public string tittle { get; set; }
    }

}
