using System;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class Session
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlAttribute("SessionId")]
		public string Id { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlIgnore]
		public bool IsAuthenticated { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlIgnore]
		public string Username { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlIgnore]
		public DateTime LogonDateTime { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlIgnore]
		public Guid ProjectId { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlIgnore]
		public DateTime LastAccess { get; set; }
	}
}