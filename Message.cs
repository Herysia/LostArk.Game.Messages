using System;
using System.Linq;

namespace LostArk.Game.Messages
{
    public class Message
    {
        public Message(DateTime time, MessageDirection direction, byte[] data)
        {
            Time = time;
            Direction = direction;
            Data = data;
        }

        public DateTime Time { get; private set; }
        public MessageDirection Direction { get; private set; }
        public byte[] Data { get; set; }

        public ushort OpCode => (ushort) (Data[2] | Data[3] << 8);

        public byte[] Payload => Data.Skip(6).ToArray();

        public CompressionFlagEnum CompressionFlag => (CompressionFlagEnum) Data[4];
        public bool Encrypted => Data[5] == 1;

        public string DebugString()
        {
            return String.Format("{0} {1} {2} {3}", OpCode, Direction == MessageDirection.ClientToServer ? "->" : "<-",
                Data.Length, BitConverter.ToString(Payload).ToLower().Replace("-", ""));
        }

        public enum CompressionFlagEnum
        {
            Uncompressed = 0,
            Lz4Unreal = 1,
            Snappy = 2,
            OodleNetwork = 3,
            Unknown = 100
        }
    }
}