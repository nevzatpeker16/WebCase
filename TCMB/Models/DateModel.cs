using System.Collections.Generic;
using System.Xml.Serialization;

namespace TCMB.Models
{
    [XmlRoot(ElementName="Tarih_Date")]
    public class DateModel {
        [XmlElement(ElementName="Currency")]
        public List<Currency> Currency { get; set; }
        [XmlAttribute(AttributeName="Tarih")]
        public string DateTr { get; set; }
        [XmlAttribute(AttributeName="Date")]
        public string DateGb { get; set; }
        [XmlAttribute(AttributeName="Bulten_No")]
        public string BuiltInNo { get; set; }
    }
}