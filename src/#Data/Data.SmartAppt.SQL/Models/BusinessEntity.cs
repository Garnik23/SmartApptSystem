using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SmartAppt.SQL.Models
{
    public class BusinessEntity
    {
        public int BusinessId { get; set; }
        public string Name { get; set; } = "";
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string TimeZoneIana { get; set; } = "Asia/Yerevan";
        public string? SettingsJson { get; set; }
        public DateTime CreatedAtUtc { get; set; }


    }
}
