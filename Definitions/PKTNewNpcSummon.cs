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
    public class PKTNewNpcSummon : ParsedMessage
    {
        public PKTNewNpcSummon(LostArkMessageReader reader) : base(reader)
        {
            Unk0 = reader.ReadByte();
            Unk1 = reader.ReadBytes(39);
            NpcStruct = new NpcStruct(reader);
        }

        public byte Unk0 {get;}
        public byte[] Unk1 {get;}
        public NpcStruct NpcStruct { get; } = new NpcStruct();
    }
}