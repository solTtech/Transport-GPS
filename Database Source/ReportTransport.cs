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
    class ReportTransport : TransportModel
    {
        public DateTime DateStartReport { get; set; }
        public DateTime DateEndReport { get; set; }
        public int Income { get; set; }

        public void saveToXml()
        {
            var transport = new XElement("Transport");

            if (File.Exists("Transport.xml") == true)
            {
                string input = File.ReadAllText("Transport.xml");
                transport = XElement.Parse(input);
            }
            else
            {
                transport = new XElement("Transport");
            }

            XElement newTransport = new XElement("Transport",
                            new XElement("Type", Type),
                            new XElement("Starts", DateStartReport.ToString("dd/MM/yyyy")),
                            new XElement("Ends", DateEndReport.ToString("dd/MM/yyyy")),
                            new XElement("Income", Income));

            transport.Add(newTransport);
            transport.Save("Transport.xml");
        }
    }
}
