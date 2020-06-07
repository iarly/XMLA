using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class OlapInfo
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("CubeInfo", typeof(CubeInfo))]
		public CubeInfo CubeInfo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("AxesInfo", typeof(AxesInfo))]
		public AxesInfo AxesInfo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("CellInfo", typeof(CellInfo))]
		public CellInfo CellInfo { get; set; }
	}
}