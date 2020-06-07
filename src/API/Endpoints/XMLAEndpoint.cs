using API.Entities;
using API.Handlers;
using API.Messages;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Xml.Schema;

namespace API.Endpoints
{
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	[ServiceContract(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
	[XmlSerializerFormat]
	public class XMLAEndpoint
	{
		public DiscoveryHandlerFactory DiscoveryHandlerFactory { get; }

		public XMLAEndpoint()
		{
			DiscoveryHandlerFactory = new DiscoveryHandlerFactory();
		}

		[OperationContract(Action = "urn:schemas-microsoft-com:xml-analysis:Discover")]
		public DiscoverResponseMessage Discover(DiscoverRequestMessage message)
		{
			return DiscoveryHandlerFactory.Discover(message);
		}

		[OperationContract(Action = "urn:schemas-microsoft-com:xml-analysis:Execute")]
		public ExecuteResponseMessage Execute(ExecuteRequestMessage message)
		{
			return new ExecuteResponseMessage()
			{
				ResultSet = new ResultSet()
				{
					EmptyRoot = new ResultXmlRoot()
				}
			};

		}

	}
}
