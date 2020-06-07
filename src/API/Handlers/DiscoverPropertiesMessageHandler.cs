using API.Entities;
using API.Entities.Rows;
using API.Messages;
using System.IO;
using System.Xml.Schema;

namespace API.Handlers
{
	public class DiscoverPropertiesMessageHandler : IDiscoverMessageHandler
	{
		public bool CanHandle(DiscoverRequestMessage message)
		{
			return message.RequestType == "DISCOVER_PROPERTIES";
		}

		public DiscoverResponseMessage Discover(DiscoverRequestMessage message)
		{
			//<row>\r\n<PropertyName>(.*)</PropertyName>\r\n<PropertyDescription>(.*)</PropertyDescription>\r\n<PropertyType>(.*)</PropertyType>\r\n<PropertyAccessType>(.*)</PropertyAccessType>\r\n<IsRequired>(.*)</IsRequired>\r\n(<Value( /){0,1}>((.*)</Value>){0,1}\r\n){0,1}</row>
			//new Row\("$1"\, "$2"\, "$3"\, "$4"\, $5\, "$9"\)\,

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
                        <xsd:element sql:field=""PropertyName"" name=""PropertyName"" type=""xsd:string"" />
                        <xsd:element sql:field=""PropertyDescription"" name=""PropertyDescription"" type=""xsd:string"" minOccurs=""0"" />
                        <xsd:element sql:field=""PropertyType"" name=""PropertyType"" type=""xsd:string"" minOccurs=""0"" />
                        <xsd:element sql:field=""PropertyAccessType"" name=""PropertyAccessType"" type=""xsd:string"" />
                        <xsd:element sql:field=""IsRequired"" name=""IsRequired"" type=""xsd:boolean"" minOccurs=""0"" />
                        <xsd:element sql:field=""Value"" name=""Value"" type=""xsd:string"" minOccurs=""0"" />
                     </xsd:sequence>
                  </xsd:complexType>
               </xsd:schema>
			");



			var schema = XmlSchema.Read(textReader, new ValidationEventHandler((a, b) => { }));

			return new DiscoverResponseMessage()
			{
				ResultSet = new ResultSet()
				{
					RowsetRoot = new ResultXmlRoot()
					{
						Schema = schema,

						XmlaItemProducer = new Enumerable(new System.Collections.Generic.List<Row>
						{
							PropertyRow.Create("Catalog", "Catalog", "string", "ReadWrite", false, "Stratws"),
							PropertyRow.Create("Timeout", "Timeout", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("Content", "Content", "string", "Write", false, "SchemaData"),
							PropertyRow.Create("DiscoverAmbiguity", "DiscoverAmbiguity", "boolean", "Write", false, "false"),
							PropertyRow.Create("Format", "Format", "string", "Write", false, "Native"),
							PropertyRow.Create("AxisFormat", "AxisFormat", "string", "Write", false, "TupleFormat"),
							PropertyRow.Create("BeginRange", "BeginRange", "int", "Write", false, "-1"),
							PropertyRow.Create("EndRange", "EndRange", "int", "Write", false, "-1"),
							PropertyRow.Create("ShowHiddenCubes", "ShowHiddenCubes", "boolean", "ReadWrite", false, "false"),
							PropertyRow.Create("MaximumRows", "MaximumRows", "int", "Write", false, ""),
							PropertyRow.Create("VisualMode", "VisualMode", "int", "Write", false, "0"),
							PropertyRow.Create("DbpropMsmdCachePolicy", "DbpropMsmdCachePolicy", "int", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdCacheRatio", "DbpropMsmdCacheRatio", "double", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdCacheMode", "DbpropMsmdCacheMode", "int", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdFlattened2", "DbpropMsmdFlattened2", "boolean", "ReadWrite", false, "false"),
							PropertyRow.Create("DbpropInitMode", "DbpropInitMode", "int", "ReadWrite", false, ""),
							PropertyRow.Create("SspropInitAppName", "SspropInitAppName", "string", "ReadWrite", false, "Microsoft SQL Server Management Studio"),
							PropertyRow.Create("SecuredCellValue", "SecuredCellValue", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("NonEmptyThreshold", "NonEmptyThreshold", "int", "ReadWrite", false, ""),
							PropertyRow.Create("SafetyOptions", "SafetyOptions", "int", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdCacheRatio2", "DbpropMsmdCacheRatio2", "double", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdUseFormulaCache", "DbpropMsmdUseFormulaCache", "string", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdDynamicDebugLimit", "DbpropMsmdDynamicDebugLimit", "int", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdDebugMode", "DbpropMsmdDebugMode", "string", "ReadWrite", false, ""),
							PropertyRow.Create("Dialect", "Dialect", "string", "ReadWrite", false, ""),
							PropertyRow.Create("ImpactAnalysis", "ImpactAnalysis", "boolean", "Write", false, "0"),
							PropertyRow.Create("SQLQueryMode", "SQLQueryMode", "string", "ReadWrite", false, "Calculated"),
							PropertyRow.Create("ClientProcessID", "ClientProcessID", "int", "ReadWrite", false, "19212"),
							PropertyRow.Create("Cube", "Cube", "string", "Write", false, ""),
							PropertyRow.Create("ReturnCellProperties", "ReturnCellProperties", "boolean", "ReadWrite", false, "false"),
							PropertyRow.Create("CommitTimeout", "CommitTimeout", "int", "Write", false, "0"),
							PropertyRow.Create("ForceCommitTimeout", "ForceCommitTimeout", "int", "Write", false, "0"),
							PropertyRow.Create("ExecutionMode", "ExecutionMode", "string", "Write", false, "Execute"),
							PropertyRow.Create("RealTimeOlap", "RealTimeOlap", "boolean", "ReadWrite", false, "false"),
							PropertyRow.Create("MdxMissingMemberMode", "MdxMissingMemberMode", "string", "Write", false, "Default"),
							PropertyRow.Create("DisablePrefetchFacts", "DisablePrefetchFacts", "boolean", "ReadWrite", false, "false"),
							PropertyRow.Create("UpdateIsolationLevel", "UpdateIsolationLevel", "int", "ReadWrite", false, "2"),
							PropertyRow.Create("DbpropMsmdOptimizeResponse", "DbpropMsmdOptimizeResponse", "long", "ReadWrite", false, "0"),
							PropertyRow.Create("ResponseEncoding", "ResponseEncoding", "string", "ReadWrite", false, "Default"),
							PropertyRow.Create("DirectQueryMode", "DirectQueryMode", "string", "ReadWrite", false, "Default"),
							PropertyRow.Create("DbpropMsmdActivityID", "DbpropMsmdActivityID", "string", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdRequestID", "DbpropMsmdRequestID", "string", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdCurrentActivityID", "DbpropMsmdCurrentActivityID", "string", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdRequestMemoryLimit", "DbpropMsmdRequestMemoryLimit", "int", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdExecutionMetrics", "DbpropMsmdExecutionMetrics", "int", "ReadWrite", false, ""),
							PropertyRow.Create("Certificate", "Certificate", "string", "ReadWrite", false, ""),
							PropertyRow.Create("AuthenticationScheme", "AuthenticationScheme", "string", "ReadWrite", false, ""),
							PropertyRow.Create("ExtAuthInfo", "ExtAuthInfo", "string", "ReadWrite", false, ""),
							PropertyRow.Create("ReturnAffectedObjects", "ReturnAffectedObjects", "int", "Write", false, ""),
							PropertyRow.Create("DataView", "DataView", "string", "ReadWrite", false, ""),
							PropertyRow.Create("RequestPriority", "RequestPriority", "int", "ReadWrite", false, ""),
							PropertyRow.Create("ApplicationContext", "ApplicationContext", "string", "ReadWrite", false, ""),
							PropertyRow.Create("DataSourceInfo", "DataSourceInfo", "string", "ReadWrite", true, ""),
							PropertyRow.Create("Password", "Password", "string", "Write", false, ""),
							PropertyRow.Create("LocaleIdentifier", "LocaleIdentifier", "int", "ReadWrite", false, "1046"),
							PropertyRow.Create("Roles", "Roles", "string", "ReadWrite", false, ""),
							PropertyRow.Create("EffectiveRoles", "EffectiveRoles", "string", "Write", false, ""),
							PropertyRow.Create("EffectiveUserName", "EffectiveUserName", "string", "Write", false, ""),
							PropertyRow.Create("DbpropMsmdMDXCompatibility", "DbpropMsmdMDXCompatibility", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("DbpropMsmdSQLCompatibility", "DbpropMsmdSQLCompatibility", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("DbpropMsmdMDXUniqueNameStyle", "DbpropMsmdMDXUniqueNameStyle", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("DbpropMsmdCompareCaseSensitiveStringFlags", "DbpropMsmdCompareCaseSensitiveStringFlags", "int", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdCompareCaseNotSensitiveStringFlags", "DbpropMsmdCompareCaseNotSensitiveStringFlags", "int", "ReadWrite", false, ""),
							PropertyRow.Create("SspropInitWsid", "SspropInitWsid", "string", "ReadWrite", false, ""),
							PropertyRow.Create("SspropInitPacketsize", "SspropInitPacketsize", "int", "ReadWrite", false, ""),
							PropertyRow.Create("ReadOnlySession", "ReadOnlySession", "int", "ReadWrite", false, ""),
							PropertyRow.Create("CustomData", "CustomData", "string", "Write", false, ""),
							PropertyRow.Create("DbpropMsmdErrorMessageMode", "DbpropMsmdErrorMessageMode", "int", "Write", false, ""),
							PropertyRow.Create("DbpropMsmdSubqueries", "DbpropMsmdSubqueries", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("DbpropMsmdAutoExists", "DbpropMsmdAutoExists", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("DbpropMsmdCellErrorMode", "DbpropMsmdCellErrorMode", "string", "ReadWrite", false, "Default"),
							PropertyRow.Create("UserMode", "UserMode", "string", "ReadWrite", false, ""),
							PropertyRow.Create("DbpropMsmdOutputExecPlan", "DbpropMsmdOutputExecPlan", "int", "ReadWrite", false, "0"),
							PropertyRow.Create("UserName", "UserName", "string", "Read", false, "AUTORIDADE NT\\IUSR"),
							PropertyRow.Create("StateSupport", "StateSupport", "string", "Read", false, "Sessions"),
							PropertyRow.Create("MDXSupport", "MDXSupport", "string", "Read", false, "Core"),
							PropertyRow.Create("MemoryLockingMode", "MemoryLockingMode", "int", "Read", false, "0"),
							PropertyRow.Create("ProviderName", "ProviderName", "string", "Read", false, "OLAP Server"),
							PropertyRow.Create("ProviderVersion", "ProviderVersion", "string", "Read", false, "15.0.32.50"),
							PropertyRow.Create("DBMSVersion", "DBMSVersion", "string", "Read", false, "15.0.32.50"),
							PropertyRow.Create("ProviderType", "ProviderType", "int", "Read", false, "6"),
							PropertyRow.Create("SQLSupport", "SQLSupport", "int", "Read", false, "512"),
							PropertyRow.Create("TransactionDDL", "TransactionDDL", "int", "Read", false, "0"),
							PropertyRow.Create("ServerName", "ServerName", "string", "Read", false, "DESKTOP-B1T79J3"),
							PropertyRow.Create("CatalogLocation", "CatalogLocation", "int", "Read", false, "1"),
							PropertyRow.Create("DbpropCatalogTerm", "DbpropCatalogTerm", "string", "Read", false, "Database"),
							PropertyRow.Create("DbpropCatalogUsage", "DbpropCatalogUsage", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropColumnDefinition", "DbpropColumnDefinition", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropConcatNullBehavior", "DbpropConcatNullBehavior", "int", "Read", false, "1"),
							PropertyRow.Create("DbpropDataSourceReadOnly", "DbpropDataSourceReadOnly", "boolean", "Read", false, "false"),
							PropertyRow.Create("DbpropGroupBy", "DbpropGroupBy", "int", "Read", false, "2"),
							PropertyRow.Create("DbpropHeterogeneousTables", "DbpropHeterogeneousTables", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropIdentifierCase", "DbpropIdentifierCase", "int", "Read", false, "8"),
							PropertyRow.Create("DbpropMaxIndexSize", "DbpropMaxIndexSize", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropMaxOpenChapters", "DbpropMaxOpenChapters", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropMaxRowSize", "DbpropMaxRowSize", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropMaxRowSizeIncludeBlob", "DbpropMaxRowSizeIncludeBlob", "boolean", "Read", false, "true"),
							PropertyRow.Create("DbpropMaxTablesInSelect", "DbpropMaxTablesInSelect", "int", "Read", false, "1"),
							PropertyRow.Create("DbpropMultiTableUpdate", "DbpropMultiTableUpdate", "boolean", "Read", false, "false"),
							PropertyRow.Create("DbpropNullCollation", "DbpropNullCollation", "int", "Read", false, "4"),
							PropertyRow.Create("DbpropOrderByColumnsInSelect", "DbpropOrderByColumnsInSelect", "boolean", "Read", false, "false"),
							PropertyRow.Create("DbpropOutputParameterAvailable", "DbpropOutputParameterAvailable", "int", "Read", false, "1"),
							PropertyRow.Create("DbpropPersistentIdType", "DbpropPersistentIdType", "int", "Read", false, "4"),
							PropertyRow.Create("DbpropPrepareAbortBehavior", "DbpropPrepareAbortBehavior", "int", "Read", false, "1"),
							PropertyRow.Create("DbpropPrepareCommitBehavior", "DbpropPrepareCommitBehavior", "int", "Read", false, "1"),
							PropertyRow.Create("DbpropProcedureTerm", "DbpropProcedureTerm", "string", "Read", false, "Calculated member"),
							PropertyRow.Create("DbpropQuotedIdentifierCase", "DbpropQuotedIdentifierCase", "int", "Read", false, "8"),
							PropertyRow.Create("DbpropSchemaUsage", "DbpropSchemaUsage", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropSqlSupport", "DbpropSqlSupport", "int", "Read", false, "512"),
							PropertyRow.Create("DbpropSubqueries", "DbpropSubqueries", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropSupportedTxnDdl", "DbpropSupportedTxnDdl", "int", "Read", false, "0"),
							PropertyRow.Create("DbpropSupportedTxnIsoLevels", "DbpropSupportedTxnIsoLevels", "int", "Read", false, "4096"),
							PropertyRow.Create("DbpropSupportedTxnIsoRetain", "DbpropSupportedTxnIsoRetain", "int", "Read", false, "292"),
							PropertyRow.Create("DbpropTableTerm", "DbpropTableTerm", "string", "Read", false, "Cube"),
							PropertyRow.Create("MdpropAggregateCellUpdate", "MdpropAggregateCellUpdate", "int", "Read", false, "4"),
							PropertyRow.Create("MdpropAxes", "MdpropAxes", "int", "Read", false, "2147483647"),
							PropertyRow.Create("MdpropFlatteningSupport", "MdpropFlatteningSupport", "int", "Read", false, "1"),
							PropertyRow.Create("MdpropMdxCaseSupport", "MdpropMdxCaseSupport", "int", "Read", false, "3"),
							PropertyRow.Create("MdpropMdxDescFlags", "MdpropMdxDescFlags", "int", "Read", false, "7"),
							PropertyRow.Create("MdpropMdxDrillFunctions", "MdpropMdxDrillFunctions", "int", "Read", false, "7"),
							PropertyRow.Create("MdpropMdxFormulas", "MdpropMdxFormulas", "int", "Read", false, "63"),
							PropertyRow.Create("MdpropMdxJoinCubes", "MdpropMdxJoinCubes", "int", "Read", false, "1"),
							PropertyRow.Create("MdpropMdxMemberFunctions", "MdpropMdxMemberFunctions", "int", "Read", false, "15"),
							PropertyRow.Create("MdpropMdxNonMeasureExpressions", "MdpropMdxNonMeasureExpressions", "int", "Read", false, "0"),
							PropertyRow.Create("MdpropMdxNumericFunctions", "MdpropMdxNumericFunctions", "int", "Read", false, "2047"),
							PropertyRow.Create("MdpropMdxObjQualification", "MdpropMdxObjQualification", "int", "Read", false, "496"),
							PropertyRow.Create("MdpropMdxOuterReference", "MdpropMdxOuterReference", "int", "Read", false, "0"),
							PropertyRow.Create("MdpropMdxQueryByProperty", "MdpropMdxQueryByProperty", "boolean", "Read", false, "true"),
							PropertyRow.Create("MdpropMdxRangeRowset", "MdpropMdxRangeRowset", "int", "Read", false, "4"),
							PropertyRow.Create("MdpropMdxSetFunctions", "MdpropMdxSetFunctions", "int", "Read", false, "524287"),
							PropertyRow.Create("MdpropMdxSlicer", "MdpropMdxSlicer", "int", "Read", false, "2"),
							PropertyRow.Create("MdpropMdxStringCompop", "MdpropMdxStringCompop", "int", "Read", false, "15"),
							PropertyRow.Create("MdpropNamedLevels", "MdpropNamedLevels", "int", "Read", false, "3"),
							PropertyRow.Create("MdpropMdxSubqueries", "MdpropMdxSubqueries", "int", "Read", false, "63"),
							PropertyRow.Create("MdpropMdxNamedSets", "MdpropMdxNamedSets", "int", "Read", false, "15"),
							PropertyRow.Create("MdpropMdxDdlExtensions", "MdpropMdxDdlExtensions", "int", "Read", false, "31"),
							PropertyRow.Create("DefaultCompatibilityLevel", "DefaultCompatibilityLevel", "int", "Read", false, "1100"),
							PropertyRow.Create("SupportedCompatibilityLevels", "SupportedCompatibilityLevels", "string", "Read", false, "1050,1100"),
						})
					}
				}
			};

		}

	}
}