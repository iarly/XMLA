using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class CrossProduct
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("Members", typeof(Members))]
        public Members[] MembersElements { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute]
        public int Size { get; set; }
    }
}