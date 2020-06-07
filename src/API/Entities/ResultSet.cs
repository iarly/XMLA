using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	[XmlRoot("return", Namespace = "urn:schemas-microsoft-com:xml-analysis")]
	public class ResultSet
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("root", typeof(ResultXmlRoot), Namespace = "urn:schemas-microsoft-com:xml-analysis:mddataset")]
		public ResultXmlRoot DatasetRoot { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("root", typeof(ResultXmlRoot), Namespace = "urn:schemas-microsoft-com:xml-analysis:empty")]
		public ResultXmlRoot EmptyRoot { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("root", typeof(ResultXmlRoot), Namespace = "urn:schemas-microsoft-com:xml-analysis:rowset")]
		public ResultXmlRoot RowsetRoot { get; set; }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="xmlTextReader"></param>
		/// <returns></returns>
		public static ResultSet LoadXml(XmlReader xmlTextReader)
		{
			return new XmlSerializer(typeof(ResultSet)).Deserialize(xmlTextReader) as ResultSet;
		}
	}
}