using API.Messages;
using System;

namespace API.Handlers
{
	public class DiscoveryHandlerFactory
	{

		public DiscoveryHandlerFactory()
		{
			DiscoverPropertiesMessageHandler = new DiscoverPropertiesMessageHandler();
			DiscoverDataSourcesMessageHandler = new DiscoverDataSourcesMessageHandler();
		}

		public DiscoverPropertiesMessageHandler DiscoverPropertiesMessageHandler { get; }
		public DiscoverDataSourcesMessageHandler DiscoverDataSourcesMessageHandler { get; }

		public DiscoverResponseMessage Discover(DiscoverRequestMessage message)
		{
			if (DiscoverPropertiesMessageHandler.CanHandle(message))
				return DiscoverPropertiesMessageHandler.Discover(message);

			if (DiscoverDataSourcesMessageHandler.CanHandle(message))
				return DiscoverDataSourcesMessageHandler.Discover(message);

			return null;
		}
	}
}