using Lib_K_Relay.Utilities;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Lib_K_Relay.Networking.Packets
{
    public class Packet
    {
        public bool Send = true;
        public byte Id;

        private byte[] _data;

        public virtual PacketType Type => PacketType.UNKNOWN;

        public virtual void Read(PacketReader r)
        {
            _data = r.ReadBytes((int)r.BaseStream.Length - 5); // All of the packet data
        }

        public virtual void Write(PacketWriter w)
        {
            w.Write(_data); // All of the packet data
        }

        public static Packet Create(PacketType type)
        {
            var st = GameData.GameData.Packets.ByName(type.ToString());
            var packet = (Packet)Activator.CreateInstance(st.Type);
            packet.Id = st.ID;
            return packet;
        }

        public static T Create<T>(PacketType type)
        {
            var packet = (Packet)Activator.CreateInstance(typeof(T));
            packet.Id = GameData.GameData.Packets.ByName(type.ToString()).ID;
            return (T)Convert.ChangeType(packet, typeof(T));
        }

        public T To<T>()
        {
            return (T)Convert.ChangeType(this, typeof(T));
        }

        public static Packet Create(byte[] data)
        {
            using (var r = new PacketReader(new MemoryStream(data)))
            {
                r.ReadInt32(); // Skip over int length
                var id = r.ReadByte();

                // 254 = We don't have the packet defined, log data and send back
                var st = GameData.GameData.Packets.ByID(
                    !GameData.GameData.Packets.Map.ContainsKey(id) ? (byte)254 : id);
                var type = st.Type;

                // Reflect the type to a new instance and read its data from the PacketReader
                var packet = (Packet)Activator.CreateInstance(type);
                packet.Id = id;
                packet.Read(r);

                // Handle all unprocessed bytes in order to ensure packet integrity
                if (r.BaseStream.Position != r.BaseStream.Length)
                {
                    var len = r.BaseStream.Length - r.BaseStream.Position;
                    packet.UnreadData = new byte[len];
                    var msg = "Packet has unread data left over: " +
                              "Id=" + packet.Id + ", Data=[";
                    for (var i = 0; i < len; i++)
                    {
                        packet.UnreadData[i] = r.ReadByte();
                        msg += packet.UnreadData[i] + (i == len - 1 ? "]" : ",");
                    }

                    PluginUtils.Log("Packet", msg);
                }

                return packet;
            }
        }

        public override string ToString()
        {
            // Use reflection to get the packet's fields and values so we don't have
            // to formulate a ToString method for every packet type.
            var fields = GetType().GetFields(BindingFlags.Public |
                                             BindingFlags.NonPublic |
                                             BindingFlags.Instance);

            var s = new StringBuilder();
            s.Append(Type + "(" + Id + ") Packet Instance");
            foreach (var f in fields) s.Append("\n\t" + f.Name + " => " + f.GetValue(this));

            return s.ToString();
        }

        public string ToStructure()
        {
            // Use reflection to build a list of the packet's fields
            var fields = GetType().GetFields(BindingFlags.Public |
                                             BindingFlags.NonPublic |
                                             BindingFlags.Instance);

            var s = new StringBuilder();
            s.Append(Type + " [" + GameData.GameData.Packets.ByName(Type.ToString()).ID + "] \nPacket Structure:\n{");
            foreach (var f in fields) s.Append("\n  " + f.Name + " => " + f.FieldType.Name);

            s.Append("\n}");
            return s.ToString();
        }
    }

    public enum PacketType
    {
        UNKNOWN,
        FAILURE,
        CREATE_SUCCESS,
        CREATE,
        PLAYER_SHOOT,
        MOVE,
        PLAYER_TEXT,
        TEXT,
        SERVER_PLAYER_SHOOT,
        DAMAGE,
        UPDATE,
        UPDATE_ACK,
        NOTIFICATION,
        NEW_TICK,
        INV_SWAP,
        USE_ITEM,
        SHOW_EFFECT,
        HELLO,
        GOTO,
        INV_DROP,
        INV_RESULT,
        RECONNECT,
        PING,
        PONG,
        MAP_INFO,
        LOAD,
        PIC,
        SET_CONDITION,
        TELEPORT,
        USE_PORTAL,
        DEATH,
        BUY,
        BUY_RESULT,
        AOE,
        GROUND_DAMAGE,
        PLAYER_HIT,
        ENEMY_HIT,
        AOE_ACK,
        SHOOT_ACK,
        OTHER_HIT,
        SQUARE_HIT,
        GOTO_ACK,
        EDIT_ACCOUNT_LIST,
        ACCOUNT_LIST,
        QUEST_OBJID,
        CHOOSE_NAME,
        NAME_RESULT,
        CREATE_GUILD,
        GUILD_RESULT,
        GUILD_REMOVE,
        GUILD_INVITE,
        ALLY_SHOOT,
        ENEMY_SHOOT,
        REQUEST_TRADE,
        TRADE_REQUESTED,
        TRADE_START,
        CHANGE_TRADE,
        TRADE_CHANGED,
        ACCEPT_TRADE,
        CANCEL_TRADE,
        TRADE_DONE,
        TRADE_ACCEPTED,
        CLIENT_STAT,
        CHECK_CREDITS,
        ESCAPE,
        FILE,
        INVITED_TO_GUILD,
        JOIN_GUILD,
        CHANGE_GUILD_RANK,
        PLAY_SOUND,
        GLOBAL_NOTIFICATION,
        RESKIN,
        ENTER_ARENA,
        LEAVE_ARENA,
        PET_COMMAND,
        PET_YARD_COMMAND,
        TINKERER_REQUEST,
        VIEW_QUESTS,
        ARENA_DEATH,
        ARENA_NEXT_WAVE,
        HATCH_EGG,
        NEW_ABILITY_UNLOCKED,
        PASSWORD_PROMPT,
        EVOLVE_PET,
        QUEST_FETCH_RESPONSE,
        REMOVE_PET,
        UPDATE_PET,
        UPGRADE_PETYARD_RESULT,
        VERIFY_EMAIL_DIALOG,
        QUEST_REDEEM_RESPONSE,
        RESKIN_UNLOCK,
        RESKIN_PET,
        KEY_INFO_REQUEST,
        KEY_INFO_RESPONSE,
        QUEUE_CANCEL,
        EXALTATION_BONUS_CHANGED,
        REDEEM_EXALTATION_REWARD,
        VAULT_CONTENT,
        FORGE_REQUEST,
        FORGE_RESULT,
        FORGE_UNLOCKED_BLUEPRINTS,
        SHOOTACK_COUNTER,
        CHANGE_ALLY_SHOOT,
        CREEP_MOVE_MESSAGE,
        // not actually needed, chat server is separate
        CHAT_HELLO_MSG,
        CHAT_TOKEN_MSG,
    }
}
