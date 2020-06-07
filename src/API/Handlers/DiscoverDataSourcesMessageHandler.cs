using API.Entities;
using API.Messages;
using System.IO;
using System.Xml.Schema;
using static API.Entities.Row;

namespace API.Handlers
{
	public class DiscoverDataSourcesMessageHandler : IDiscoverMessageHandler
	{
		public bool CanHandle(DiscoverRequestMessage message)
		{
			return message.RequestType == "DISCOVER_DATASOURCES";
		}

		public DiscoverResponseMessage Discover(DiscoverRequestMessage message)
		{
			var textReader = new StringReader(@"			
				<xsd:schema xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:sql=""urn:schemas-microsoft-com:xml-sql"" targetNamespace=""urn:schemas-microsoft-com:xml-analysis:rowset"" elementFormDefault=""qualified"">
                  <xsd:element name=""root"">
                     <xsd:complexType>
                        <xsd:sequence minOccurs=""0"" maxOccurs=""unbounded"">
                           <xsd:element name=""row"" type=""row"" />
                        </xsd:sequence>
                     </xsd:complexType>
                  </xsd:element>
                  <xsd:simpleType name=""uuid"">
                     <xsd:restriction base=""xsd:string"">
                        <xsd:pattern value=""[0-9a-zA-Z]{8}-[0-9a-zA-Z]{4}-[0-9a-zA-Z]{4}-[0-9a-zA-Z]{4}-[0-9a-zA-Z]{12}"" />
                     </xsd:restriction>
                  </xsd:simpleType>
                  <xsd:complexType name=""xmlDocument"">
                     <xsd:sequence>
                        <xsd:any />
                     </xsd:sequence>
                  </xsd:complexType>
                  <xsd:complexType name=""row"">
                     <xsd:sequence>
                        <xsd:element sql:field=""DataSourceName"" name=""DataSourceName"" type=""xsd:string"" />
                        <xsd:element sql:field=""DataSourceDescription"" name=""DataSourceDescription"" type=""xsd:string"" minOccurs=""0"" />
                        <xsd:element sql:field=""URL"" name=""URL"" type=""xsd:string"" minOccurs=""0"" />
                        <xsd:element sql:field=""DataSourceInfo"" name=""DataSourceInfo"" type=""xsd:string"" minOccurs=""0"" />
                        <xsd:element sql:field=""ProviderName"" name=""ProviderName"" type=""xsd:string"" />
                        <xsd:element sql:field=""ProviderType"" name=""ProviderType"" type=""xsd:string"" minOccurs=""0"" maxOccurs=""unbounded"" />
                        <xsd:element sql:field=""AuthenticationMode"" name=""AuthenticationMode"" type=""xsd:string"" minOccurs=""0"" />
                     </xsd:sequence>
                  </xsd:complexType>
               </xsd:schema>
			");

			var schema = XmlSchema.Read(textReader, new ValidationEventHandler((a, b) => { }));

			return new DiscoverResponseMessage()
			{
				ResultSet = new Entities.ResultSet()
				{
					RowsetRoot = new Entities.ResultXmlRoot()
					{
						Schema = schema,

						XmlaItemProducer = new Entities.Enumerable(new System.Collections.Generic.List<Row>
						{
							DataSourceRow.Create("SERVER", "", "", "", "Stratws", "Authenticated", "MDP", "TPD", "DMP")
						})
					}
				}
			};

		}

	}
}