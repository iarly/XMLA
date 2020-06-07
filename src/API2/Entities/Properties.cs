using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
    [DataContract(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
    public class Properties
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public PropertyList PropertyList { get; set; }
    }
}