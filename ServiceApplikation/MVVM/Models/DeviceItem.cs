using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplikation.MVVM.Models
{
    public class DeviceItem
    {
        public string? DeviceID { get; set; }
        public string? Placement { get; set; }
        public string? DeviceType { get; set; }
        public bool IsActive { get; set; }
    }
}
