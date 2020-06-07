using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class EndSession
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("SessionId")]
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAnyElement]
        public XmlNode[] RowElements { get; set; }
    }
}