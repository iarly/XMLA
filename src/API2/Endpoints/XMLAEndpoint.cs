using API.Entities;
using API.Messages;
using System.ServiceModel;

namespace API.Endpoints
{
	[ServiceContract(Namespace = "urn:schemas-microsoft-com:xml-analysis")]
	public class XMLAEndpoint
	{
		[OperationContract(Action = "urn:schemas-microsoft-com:xml-analysis:Discover")]
		public DiscoverResponseMessage Discover(DiscoverRequestMessage message)
		{
			return new DiscoverResponseMessage()
			{
				ResultSet = new Entities.ResultSet()
				{
					RowsetRoot = new Entities.ResultXmlRoot()
					{
						XmlaItemProducer = new Entities.Enumerable(new System.Collections.Generic.List<Row>
						{
							new Row()
						})
					}
				}
			};
		}

		//[OperationContract(Action = "urn:schemas-microsoft-com:xml-analysis:Discover")]
		//public void Discover([MessageParameter(Name = "RequestType")] string requestType,
		//	[MessageParameter(Name = "Restrictions")] Restrictions restrictions,
		//	[MessageParameter(Name = "Properties")] Properties properties)
		//{

		//}

		//[OperationContract(Action = "urn:schemas-microsoft-com:xml-analysis:Execute")]
		//public void Execute([MessageParameter(Name = "Command")] Command command)
		//{

		//}
	}
}
