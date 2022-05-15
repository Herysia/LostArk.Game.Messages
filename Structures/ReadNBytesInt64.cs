using System;
using System.Collections.Generic;
using LostArk.Game.Messages.Services;
using LostArk.Game.Messages.Types;

namespace LostArk.Game.Messages.Structures
{
    public class ReadNBytesInt64
    {
        public bool valid = false;
        internal ReadNBytesInt64()
        {
            //Made for conditional structures
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

        internal ReadNBytesInt64(LostArkMessageReader reader)
        {
            valid = true;
            var flag = reader.ReadByte();
            var bytes = reader.ReadBytes((flag >> 1) & 7);
            var result = (_bytesToInt64(bytes) << 4) | (uint) (flag >> 4);
            Value = (flag & 1) == 0 ? result : -result;
        }

        public long Value { get; }
    }
}