using System.Xml;
using System.Xml.Serialization;

namespace API.Entities
{
	public partial class Row
	{
		public class DataSourceRow
		{
			private DataSourceRow(string dataSourceName, string dataSourceDescription, string url, string dataSourceInfo, string providerName, string authenticationMode, params string[] providerType)
			{
				DataSourceName = dataSourceName;
				DataSourceDescription = dataSourceDescription;
				URL = url;
				DataSourceInfo = dataSourceInfo;
				ProviderName = providerName;
				AuthenticationMode = authenticationMode;
				ProviderType = providerType;
			}

			public static Row Create(string dataSourceName, string dataSourceDescription, string url, string dataSourceInfo, string providerName, string authenticationMode, params string[] providerType)
			{
				return new Row(new DataSourceRow(dataSourceName, dataSourceDescription, url, dataSourceInfo, providerName, authenticationMode, providerType));
			}

			[XmlElement]
			public string DataSourceName { get; set; }
			[XmlElement]
			public string DataSourceDescription { get; set; }
			[XmlElement]
			public string URL { get; set; }
			[XmlElement]
			public string DataSourceInfo { get; set; }
			[XmlElement]
			public string ProviderName { get; set; }
			[XmlElement]
			public string AuthenticationMode { get; set; }
			[XmlElement]
			public string[] ProviderType { get; set; }
		}
	}
}