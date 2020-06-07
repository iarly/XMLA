using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Property 
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        [XmlAttribute("PropertyName")]
        public string PropertyName { get; set; }
        /// <summary>
        /// A localizable text description of the property.
        /// </summary>
        [XmlAttribute("PropertyDescription")]
        public string PropertyDescription { get; set; }
        /// <summary>
        /// The XML data type of the property.
        /// </summary>
        [XmlAttribute("PropertyType")]
        public string PropertyType { get; set; }
        /// <summary>
        /// Access for the property. The value can be Read, Write, or ReadWrite.
        /// </summary>
        [XmlAttribute("PropertyAccessType")]
        public string PropertyAccessType { get; set; }
        /// <summary>
        /// True if a property is required, false if it is not required.
        /// </summary>
        [XmlAttribute("IsRequired")]
        public bool IsRequired { get; set; }
        /// <summary>
        /// The current value of the property.
        /// </summary>
        [XmlAttribute("Value")]
        public string Value { get; set; }
    }
}