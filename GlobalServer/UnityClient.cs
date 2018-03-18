using Photon.SocketServer;
using System.Linq;
using System.Collections.Generic;
using PhotonHostRuntimeInterfaces;
using ExitGames.Logging;

namespace GlobalServer
{
    class UnityClient : ClientPeer
    {
        private readonly ILogger Log = LogManager.GetCurrentClassLogger();

        public UnityClient(InitRequest initRequest) : base(initRequest)
        {
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
            Log.Info(this.LocalIP + " try to disconnect...");
        }
    }
}
