using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_manager.Models
{
    internal class DriverModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string Category { get; set; }
        public string Login { get; set; }
        public int Salary { get; set; }
    }
}
