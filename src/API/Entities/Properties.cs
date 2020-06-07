using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    [XmlRoot("Properties")]
    [DataContract(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
    public class Properties
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public PropertyList PropertyList { get; set; }
    }
}