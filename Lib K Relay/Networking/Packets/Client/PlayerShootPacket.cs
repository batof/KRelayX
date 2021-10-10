using Lib_K_Relay.Networking.Packets.DataObjects;

namespace Lib_K_Relay.Networking.Packets.Client
{
    public class PlayerShootPacket : Packet
    {
        public float Angle;
        public byte BulletId;
        public byte BurstId;
        public ushort ContainerType;
        public short LifeMultiplier;
        public Location Position;
        public short SpeedMultiplier;
        public int Time;

        public override PacketType Type => PacketType.PLAYERSHOOT;

        public override void Read(PacketReader r)
        {
            Time = r.ReadInt32();
            BulletId = r.ReadByte();
            ContainerType = r.ReadUInt16();
            Position = (Location) new Location().Read(r);
            Angle = r.ReadSingle();
            SpeedMultiplier = r.ReadInt16();
            LifeMultiplier = r.ReadInt16();
            BurstId = r.ReadByte();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Time);
            w.Write(BulletId);
            w.Write(ContainerType);
            Position.Write(w);
            w.Write(Angle);
            w.Write(SpeedMultiplier);
            w.Write(LifeMultiplier);
            w.Write(BurstId);
        }
    }
}