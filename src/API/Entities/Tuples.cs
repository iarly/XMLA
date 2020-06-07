using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class Tuples
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlElement("Tuple", typeof(Tuple))]
		public Enumerable TupleProducer { get; set; }
	}
}