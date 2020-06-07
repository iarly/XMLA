using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class CellInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAnyElement]
        public XmlElement[] CellInfoElements { get; set; }
    }
}