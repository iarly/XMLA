using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class HierarchyInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAnyElement]
        public Enumerable DimensionPropertyProducer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}