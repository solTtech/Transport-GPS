using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_manager.Models
{
    public class WaybillModel
    {
        public int DriverId { get; set; }

        public int TransportId { get; set; }
        
        public int Distance { get; set; }
        
        public int Price { get; set; }
        
        public string Date { get; set; }
    }
}
