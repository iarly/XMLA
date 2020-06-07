using System.Collections;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class ResultXmlRoot
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlNamespaceDeclarations()]
        public XmlSerializerNamespaces xmlsn
        {
            get
            {
                XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
                xsn.Add("xsd", "http://www.w3.org/2001/XMLSchema");
                xsn.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                xsn.Add("msxmla", "http://schemas.microsoft.com/analysisservices/2003/xmla");
                return xsn;
            }
            set
            {
                //Just provide an empty setter. 
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("schema", typeof(XmlSchema), Namespace = "http://www.w3.org/2001/XMLSchema")]
        public XmlSchema Schema { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("row", typeof(Row))]
        [XmlElement("Axes", typeof(Axes))]
        [XmlElement("OlapInfo", typeof(OlapInfo))]
        [XmlElement("CellData", typeof(CellData))]
        public Enumerable XmlaItemProducer { get; set; }
    }
}