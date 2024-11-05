using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotManager.Models
{
    public class Response
    {
        public int ResponseID { get; set; } // ID của Response

        public string ResponseText { get; set; } // Nội dung của Response

        public int IntentID { get; set; }

        //public Intent IntentNavigation { get; set; }
    }
}
