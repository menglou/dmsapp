using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.ApiModel
{
   public class Token
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string token { get; set; }
        public double expires_in { get; set; }
        public string token_type { get; set; }
        public string status { get; set; }
    }
}
