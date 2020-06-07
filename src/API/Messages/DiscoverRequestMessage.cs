using API.Entities;
using System.ServiceModel;

namespace API.Messages
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(WrapperName = "Discover", WrapperNamespace = "urn:schemas-microsoft-com:xml-analysis")]
    public class DiscoverRequestMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMember]
        public string RequestType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMember]
        public Restrictions Restrictions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMember]
        public Properties Properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader]
        public Session Session { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader]
        public BeginSession BeginSession { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader]
        public EndSession EndSession { get; set; }        
    }
}