using Lib_K_Relay;
using Lib_K_Relay.Interface;
using Lib_K_Relay.Networking;
using Lib_K_Relay.Networking.Packets;
using Lib_K_Relay.Networking.Packets.Server;
using Lib_K_Relay.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_K_Relay.Networking.Packets.DataObjects;

namespace ReconHelper
{
    public class ReconHelper : IPlugin {
        private List<ReconnectPacket> _recons;
        public string GetAuthor()
        { return "him"; }

        public string GetName()
        { return "ReconHelper"; }

        public string GetDescription()
        { return "Store and reuse reconnect keys"; }

        public string[] GetCommands()
        { return new string[] { "/r" }; }

        public void Initialize(Proxy proxy)
        {
            proxy.HookPacket(PacketType.RECONNECT, OnReconnect);
            proxy.HookCommand("r", OnCommand);
        }

        private static void OnCommand(Client client, string command, string[] args)
        {
            Random r = new Random();
            int val = 0;
            for (int i = 0; i < 10 ; i++)
            {
                val += r.Next(400000, 723411);
                client.SendToClient(PluginUtils.CreateNotification(
                    client.ObjectId, val, "YOU ARE SPECIAL!"));
            }
        }

        private static void OnReconnect(Client client, Packet packet)
        {
            
        }
    }
}
