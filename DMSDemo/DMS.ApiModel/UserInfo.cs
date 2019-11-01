using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.ApiModel
{
   public class UserInfo
    {
     
        public bool success { get; set; }
        public string msg { get; set; }
        public response response { get; set; }
    }

    public class response
    {
        public string id { get; set; }
        public string user_no { get; set; }
        public string user_name { get; set; }
        public string mobile { get; set; }
        public string card_no { get; set; }
        public string pass_word { get; set; }
        public string createtime { get; set; }
        public string createby { get; set; }
        public string updateby { get; set; }
        public string updatetime { get; set; }
        public int is_effective { get; set; }
        public string user_type { get; set; }
      
    }
}
