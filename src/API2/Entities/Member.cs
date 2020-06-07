using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Member
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAnyElement]
        public List<XmlElement> MemberProperties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute]
        public string Hierarchy { get; set; }
    }
}