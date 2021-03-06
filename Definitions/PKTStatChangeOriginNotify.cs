/*
 * This file has been Auto Generated, Please do not edit.
 * If you need changes, follow the instructions written in the readme.md
 *
 * Generated by Herysia.
 */

using System;
using System.Collections.Generic;
using LostArk.Game.Messages.Services;
using LostArk.Game.Messages.Structures;
using LostArk.Game.Messages.Types;

namespace LostArk.Game.Messages.Definitions
{
    public class PKTStatChangeOriginNotify : ParsedMessage
    {
        public PKTStatChangeOriginNotify(LostArkMessageReader reader) : base(reader)
        {
            Struct_44_0 = new Struct_44(reader);
            Struct_44_1 = new Struct_44(reader);
            Unk2 = reader.ReadInt64();
            Unk3 = reader.ReadByte();
            if(Unk3 == 1)
            {
                Unk3_0 = reader.ReadInt32();
            }
            Unk4 = reader.ReadByte();
        }

        public Struct_44 Struct_44_0 {get;} = new Struct_44();
        public Struct_44 Struct_44_1 {get;} = new Struct_44();
        public long Unk2 {get;}
        public byte Unk3 {get;}
        public int Unk3_0 {get;}
        public byte Unk4 {get;}
    }
}