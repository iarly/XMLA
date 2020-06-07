using API.Entities;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;

namespace API.Messages
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(WrapperName = "DiscoverResponse")]
    public class DiscoverResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMember(Name = "return")]
        public ResultSet ResultSet { get; set; }
    }
}