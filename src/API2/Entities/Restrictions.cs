using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot("Restrictions")]
    [DataContract]
    public class Restrictions
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("RestrictionList", typeof(RestrictionList))]
        [DataMember]
        public RestrictionList RestrictionListElement;
    }
}