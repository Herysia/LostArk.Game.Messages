/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArk.Game.Messages.Services;
using LostArk.Game.Messages.Types;

namespace LostArk.Game.Messages.Structures
{
    public class Struct_44
    {
        public bool valid = false;
        internal Struct_44()
        {
            //Made for conditional structures
        }

        internal Struct_44(LostArkMessageReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 152)
            {
                for(var i = 0; i < Unk0; i++)
                {
                    sub_Unk0_0.Add(new sub_Unk0(reader));
                }
            }
        }

        public short Unk0 {get;}
        public class sub_Unk0
        {
            public bool valid = false;
            internal sub_Unk0()
            {
                //Made for conditional structures
            }
            internal sub_Unk0(LostArkMessageReader reader)
            {
                valid = true;
                ReadNBytesInt64_0 = new ReadNBytesInt64(reader);
                Unk0_1 = reader.ReadByte();
            }

            public ReadNBytesInt64 ReadNBytesInt64_0 {get;} = new ReadNBytesInt64();
            public byte Unk0_1 {get;}
        }
        public List<sub_Unk0> sub_Unk0_0 {get;} = new List<sub_Unk0>();
    }
}