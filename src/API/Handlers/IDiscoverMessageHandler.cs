using API.Messages;

namespace API.Handlers
{
	public interface IDiscoverMessageHandler
	{
		bool CanHandle(DiscoverRequestMessage message);
		DiscoverResponseMessage Discover(DiscoverRequestMessage message);
	}
}