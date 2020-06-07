using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Cube
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("CubeName")]
        public string CubeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("LastDataUpdate", Namespace="http://schemas.microsoft.com/analysisservices/2003/engine")]
        public string LastDataUpdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("LastSchemaUpdate", Namespace="http://schemas.microsoft.com/analysisservices/2003/engine")]
        public string LastSchemaUpdate { get; set; }
    }
}