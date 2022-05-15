using System;
using System.IO;

namespace LostArk.Game.Messages.Types
{
    public struct CounterAttackEvent
    {
        private static readonly ushort _size = 22;

        public CounterAttackEvent(byte[] data)
        {
            if (data.Length != _size)
            {
                throw new Exception($"CounterAttackEvent size mismatch. Expected {_size} but received {data.Length}");
            }

            TargetId = BitConverter.ToInt64(data, 5);
            SourceId = BitConverter.ToInt64(data, 14);
        }

        public long SourceId { get; }

        public long TargetId { get; }
    }
}