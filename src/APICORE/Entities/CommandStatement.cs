using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot("Command")]
    public class CommandStatement
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Statement", typeof(string))]
        public string Statement { get; set; }
    }
}