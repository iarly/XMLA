using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
	/// <summary>
	/// 
	/// </summary>
	public class RowNode : XmlElement
	{
		/// <summary>
		/// 
		/// </summary>
		[XmlAttribute("xmlns")]
		public string xmlns
		{
			get
			{
				return null;
			}
			set
			{

			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static RowNode CreateNode(string name, string value)
		{
			XmlDocument doc = new XmlDocument();
			return new RowNode(name, value, doc);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="doc"></param>
		public RowNode(string name, string value, XmlDocument doc)
			: base("", name, "", doc)
		{
			this.InnerText = value;
		}
	}
}