using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Download_Image_Inspireuplift.Model.Instagram
{
    public class Variable
    {
        public Data data { get; set; }
        public string username { get; set; }
        public bool __relay_internal__pv__PolarisIsLoggedInrelayprovider { get; set; }
        public bool __relay_internal__pv__PolarisFeedShareMenurelayprovider { get; set; }
    }

    public class Data
    {
        public int count { get; set; }
        public bool include_relationship_info { get; set; }
        public bool latest_besties_reel_media { get; set; }
        public bool latest_reel_media { get; set; }
    }

    public class Variables
    {
        public string after { get; set; }
        public object before { get; set; }
        public Datas data { get; set; }
        public int first { get; set; }
        public object last { get; set; }
        public string username { get; set; }
        public bool __relay_internal__pv__PolarisIsLoggedInrelayprovider { get; set; }
        public bool __relay_internal__pv__PolarisFeedShareMenurelayprovider { get; set; }
    }

    public class Datas
    {
        public int count { get; set; }
        public bool include_relationship_info { get; set; }
        public bool latest_besties_reel_media { get; set; }
        public bool latest_reel_media { get; set; }
    }


}
