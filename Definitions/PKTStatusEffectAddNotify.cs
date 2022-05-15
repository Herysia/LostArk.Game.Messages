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
    public class PKTStatusEffectAddNotify : ParsedMessage
    {
        public PKTStatusEffectAddNotify(LostArkMessageReader reader) : base(reader)
        {
            Unk0 = reader.ReadByte();
            Unk1 = reader.ReadInt64();
            Unk2 = reader.ReadInt64();
            Struct_601_3 = new Struct_601(reader);
        }

        public byte Unk0 {get;}
        public long Unk1 {get;}
        public long Unk2 {get;}
        public Struct_601 Struct_601_3 {get;} = new Struct_601();
    }
}