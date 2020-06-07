using System.Xml;
using System.Xml.Serialization;

namespace API.Entities.Rows
{
	public class PropertyRow
	{
		public static Row Create(string propertyName, string propertyDescription, string propertyType, string propertyAccessType, bool isRequired, string value)
		{
			return new Row(new PropertyRow(propertyName, propertyDescription, propertyType, propertyAccessType, isRequired, value));
		}

		private PropertyRow(string propertyName, string propertyDescription, string propertyType, string propertyAccessType, bool isRequired, string value)
		{
			PropertyName = propertyName;
			PropertyDescription = propertyDescription;
			PropertyType = propertyType;
			PropertyAccessType = propertyAccessType;
			IsRequired = isRequired;
			Value = value;
		}

		[XmlElement]
		public string PropertyName { get; set; }
		[XmlElement]
		public string PropertyDescription { get; set; }
		[XmlElement]
		public string PropertyType { get; set; }
		[XmlElement]
		public string PropertyAccessType { get; set; }
		[XmlElement]
		public bool IsRequired { get; set; }
		[XmlElement]
		public string Value { get; set; }
	}
}