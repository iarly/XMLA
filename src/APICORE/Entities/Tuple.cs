using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class Tuple
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("Member", typeof(Member))]
		public Member[] MemberElements { get; set; }
	}
}