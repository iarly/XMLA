using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Axes
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Axis", typeof(Axis))]
        public Axis[] AxisElements { get; set; }
    }
}