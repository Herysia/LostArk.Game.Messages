using System;
using System.Collections.Generic;
using System.IO;
using LostArk.Game.Messages.Services;
using LostArk.Game.Messages.Types;

namespace LostArk.Game.Messages.Structures
{
    public class Read2or8BBytesProcessed
    {
        public bool valid = false;
        internal Read2or8BBytesProcessed()
        {
            //Made for conditional structures
        }

        internal Read2or8BBytesProcessed(LostArkMessageReader reader)
        {
            valid = true;
            var s = reader.ReadUInt16();
            reader.BaseStream.Position = 0;
            if ((s & 0xfff) < 0x81)
            {
                Value = reader.ReadInt64();
            }
            else
            {
                Value = s & 0xFFF | 0x11000;
            }
        }

        public Int64 Value { get; }
    }
}