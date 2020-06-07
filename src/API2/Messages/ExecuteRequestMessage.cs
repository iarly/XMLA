using API.Entities;
using System.ServiceModel;

namespace API.Messages
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(WrapperName = "Execute", WrapperNamespace = "urn:schemas-microsoft-com:xml-analysis")]
    public class ExecuteRequestMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMember(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
        public CommandStatement Command { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMember(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
        public Properties Properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader(Namespace = "http://schemas.microsoft.com/analysisservices/2008/engine/100")]
        public API.Entities.Version Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
        public Session Session { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
        public BeginSession BeginSession { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MessageHeader(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
        public EndSession EndSession { get; set; }
    }
}