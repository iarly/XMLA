using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
	[DataContract(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
	public class PropertyList
	{
		[DataMember(Name = "Timeout")]
		public int Timeout { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlAnyElement]
		public List<XmlElement> Elements { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement]
		public string LocaleIdentifier { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement]
		public string Catalog { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement]
		public int ReadOnlySession { get; set; }
	}
}