namespace Lib_K_Relay.Networking.Packets.Server
{
    public class MapInfoPacket : Packet
    {
        public bool AllowPlayerTeleport;
        public int Background;
        public int Difficulty;
        public string DisplayName;
        public uint Fp;
        public uint GameOpenedTime;
        public int Height;
        public short MaxPlayers;
        public string Name;
        public string RealmName;
        public bool ShowDisplays;
        public int Unknown;
        public string Version;
        public int Width;

        public override PacketType Type => PacketType.MAPINFO;

        public override void Read(PacketReader r)
        {
            Width = r.ReadInt32();
            Height = r.ReadInt32();
            Name = r.ReadString();
            DisplayName = r.ReadString();
            RealmName = r.ReadString();
            Fp = r.ReadUInt32();
            Background = r.ReadInt32();
            Difficulty = r.ReadInt32();
            AllowPlayerTeleport = r.ReadBoolean();
            ShowDisplays = r.ReadBoolean();
            MaxPlayers = r.ReadInt16();
            GameOpenedTime = r.ReadUInt32();
            Version = r.ReadString();
            Unknown = r.ReadInt32();
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Width);
            w.Write(Height);
            w.Write(Name);
            w.Write(DisplayName);
            w.Write(RealmName);
            w.Write(Fp);
            w.Write(Background);
            w.Write(Difficulty);
            w.Write(AllowPlayerTeleport);
            w.Write(ShowDisplays);
            w.Write(MaxPlayers);
            w.Write(GameOpenedTime);
            w.Write(Version);
            w.Write(Unknown);
        }
    }
}