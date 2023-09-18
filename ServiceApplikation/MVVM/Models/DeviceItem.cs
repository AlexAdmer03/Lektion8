using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string? Icon { get; set; }

        private void SetIcon()
        {
            switch (DeviceType?.ToLower()) 
            {
                case "light":
                    icon = "\uf0eb";
                    break;
                case "fan":
                    icon = "\ue004b";
                    break;
                default:
                    Icon = "\uf2db4";
                    break;
            
            }

        }
    }
}
