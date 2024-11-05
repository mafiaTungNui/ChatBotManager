using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotManager.Models
{
    public class Intent
    {
        public int IntentID { get; set; } // ID của Intent

        public string IntentName { get; set; } // Tên của Intent

        public DateTime CreatedAt { get; set; } = DateTime.Now; // Thời gian tạo Intent

        // Danh sách các Response liên kết với Intent này
        //public ICollection<Response> Responses { get; set; }
    }
}
