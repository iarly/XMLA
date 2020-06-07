using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class CubeInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Cube", typeof(Cube))]
        public Cube[] CubeElements { get; set; }
    }
}