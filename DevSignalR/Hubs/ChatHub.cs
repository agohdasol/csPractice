using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace DevSignalR.Hubs
{
  [HubName("chat")]
  public class ChatHub : Hub
  {
    public void ClientToServer(string msg)
    {
      Clients.All.serverToClient(msg);
    }
  }
}