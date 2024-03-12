using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Model.Redbubble
{
    public class Variable_redbubble
    {
        public string operationName { get; set; }
        public Variables variables { get; set; }
        public string query { get; set; }
    }

    public class Variables
    {
        public string query { get; set; }
        public Queryparams queryParams { get; set; }
        public string locale { get; set; }
        public string country { get; set; }
        public string currency { get; set; }
        public string[] previewTypeIds { get; set; }
        public string experience { get; set; }
    }

    public class Queryparams
    {
        public object[] queryParamItems { get; set; }
        public int pageSize { get; set; }
        public string artistUserName { get; set; }
    }

}
