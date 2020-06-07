using API.Entities;
using System.ServiceModel;

namespace API.Messages
{
	/// <summary>
	/// 
	/// </summary>
	[MessageContract(WrapperName = "ExecuteResponse")]
	public class ExecuteResponseMessage
	{
		/// <summary>
		/// 
		/// </summary>
		[MessageBodyMember(Name = "return")]
		public ResultSet ResultSet { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[MessageHeader]
		public Session Session { get; set; }
	}
}