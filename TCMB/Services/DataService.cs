using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TCMB.Models;

namespace TCMB.Services
{
    public class DataService
    {
        public List<Currency> GetData()
        {
            var request = (HttpWebRequest) WebRequest.Create("https://www.tcmb.gov.tr/kurlar/today.xml");
            var response = (HttpWebResponse) request.GetResponse();

            var reader = new StreamReader(response.GetResponseStream());

            XmlSerializer serializer = new XmlSerializer(typeof(DateModel));
            var resultingMessage = (DateModel)serializer.Deserialize(reader);
            if (resultingMessage != null) return resultingMessage.Currency;
            throw new Exception("TCMB Sunucusuna şuanda ulaşılamıyor");
        }
    }
}