using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	[XmlRoot(ElementName = "Version", Namespace = "http://schemas.microsoft.com/analysisservices/2008/engine/100")]
	[DataContract(Namespace = "http://schemas.microsoft.com/analysisservices/2008/engine/100")]
	public class Version
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlAttribute]
		public string Sequence { get; set; }
	}
}