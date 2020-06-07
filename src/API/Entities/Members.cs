using System.Collections;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Members
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute]
        public string Hierarchy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Member", typeof(Member))]
        public Enumerable MemberProducer { get; set; }
    }
}