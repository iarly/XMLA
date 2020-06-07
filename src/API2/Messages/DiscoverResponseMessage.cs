using API.Entities;
using System.Runtime.Serialization;
using System.ServiceModel;

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
        [DataMember(Name = "return")]
        public ResultSet ResultSet { get; set; }
    }
}