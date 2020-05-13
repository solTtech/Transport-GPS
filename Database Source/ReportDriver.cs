using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using transport_manager.Models;

namespace transport_manager.Database_Source
{
    internal class ReportDriver : DriverModel
    {
        public DateTime DateStartReport { get; set; }
        public DateTime DateEndReport { get; set; }
        public int Income { get; set; }
        public void saveToXml()
        {
            var driver = new XElement("Driver");

            if (File.Exists("Driver.xml") == true)
            {
                string input = File.ReadAllText("Driver.xml");
                driver = XElement.Parse(input);
            }
            else
            {
                driver = new XElement("Driver");
            }

            XElement newDriver = new XElement("Driver",
                            new XElement("Name", Name),
                            new XElement("Surname", Surname),
                            new XElement("Fathername", Fathername),
                            new XElement("Starts", DateStartReport.ToString("dd/MM/yyyy")),
                            new XElement("Ends", DateEndReport.ToString("dd/MM/yyyy")),
                            new XElement("Income", Income));

            driver.Add(newDriver);
            driver.Save("Driver.xml");
        }
    }
}
