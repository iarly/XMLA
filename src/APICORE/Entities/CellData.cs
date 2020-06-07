using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class CellData
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAnyElement]
        public XmlNode[] RowElements { get; set; }
    }
}