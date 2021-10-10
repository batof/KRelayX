using Lib_K_Relay.Utilities;

namespace Lib_K_Relay.Networking.Packets.Server
{
    public class NotificationPacket : Packet
    {
        public short Unknown;
        public int Color;
        public string Message;
        public int ObjectId;
        public short Unknown2;

        public override PacketType Type => PacketType.NOTIFICATION;

        public override void Read(PacketReader r)
        {
            Unknown = r.ReadInt16();
            Message = r.ReadString();
            if (Unknown == 1562) {
                ObjectId = r.ReadInt32();
                Color = r.ReadInt32();
            }

            // this might be 2 bools instead
            if (Unknown == 1058) {
                Unknown2 = r.ReadInt16();
            }
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Unknown);
            w.Write(Message);
            if (Unknown == 1562) {
                w.Write(ObjectId);
                w.Write(Color);
            }

            if (Unknown == 1058) {
                w.Write(Unknown2);
            }
        }
    }
}