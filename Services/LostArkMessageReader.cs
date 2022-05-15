using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LostArk.Game.Messages.Types;

namespace LostArk.Game.Messages.Services
{
    // Used by `ParsedMessage`s to parse themselves
    public class LostArkMessageReader : BinaryReader
    {
        public LostArkMessageReader(Message message) : base(GetStream(message), Encoding.Unicode)
        {
            Message = message;
        }

        public Message Message { get; private set; }

        private static MemoryStream GetStream(Message message)
        {
            return new MemoryStream(message.Payload, 0, message.Payload.Length, false, true);
        }

        public void Skip(int count)
        {
            ReadBytes(count);
        }

        public string ReadLostArkString()
        {
            var size = ReadUInt16();
            var builder = new StringBuilder();
            try
            {
                while (size-- != 0)
                {
                    builder.Append(ReadChar());
                }
            }
            catch
            {
                return builder.ToString();
            }

            return builder.ToString();
        }

        private long _bytesToInt64(byte[] bytes)
        {
            if (bytes.Length == 0)
                return 0;
            if (bytes.Length > 8)
                throw new Exception(
                    $"_bytesToInt64(byte[]) cannot be called with more than 8 bytes (Called with: {bytes.Length} bytes)");
            var value = new byte[8];
            Buffer.BlockCopy(bytes, 0, value, 0, bytes.Length);
            return BitConverter.ToInt64(value, 0);
        }

        private long _ReadInt64NBytes(byte flag) //7FF6B1AC5EE0, used in MANY packets
        {
            var bytes = ReadBytes((flag >> 1) & 7);
            var result = (_bytesToInt64(bytes) << 4) | (uint) (flag >> 4);
            return (flag & 1) == 0 ? result : -result;
        }

        public List<byte> ReadByteList(int count)
        {
            return new List<byte>(ReadBytes(count));
        }
    }
}