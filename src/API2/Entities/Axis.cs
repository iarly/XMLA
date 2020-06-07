using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Axis
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Tuples", typeof(Tuples))]
        [XmlElement("CrossProduct", typeof(CrossProduct))]
        public Enumerable AxisContentProducer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("name")]
        public string AxisName { get; set; }
    }
}