﻿using Lib_K_Relay.Networking.Packets.DataObjects;

namespace Lib_K_Relay.Networking.Packets.Client
{
    public class InvDropPacket : Packet
    {
        public SlotObject Slot;

        public override PacketType Type
        { get { return PacketType.INVDROP; } }

        public override void Read(PacketReader r)
        {
            Slot = (SlotObject)new SlotObject().Read(r);
        }

        public override void Write(PacketWriter w)
        {
            Slot.Write(w);
        }
    }
}
