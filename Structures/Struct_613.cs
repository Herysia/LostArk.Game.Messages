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
    public class Struct_613
    {
        public bool valid = false;
        internal Struct_613()
        {
            //Made for conditional structures
        }

        internal Struct_613(LostArkMessageReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt32();
            Unk1 = reader.ReadByte();
            if(Unk1 == 1)
            {
                Unk1_0 = reader.ReadBytes(12);
            }
            Unk2 = reader.ReadBytes(12);
            Unk3 = reader.ReadInt32();
        }

        public int Unk0 {get;}
        public byte Unk1 {get;}
        public byte[] Unk1_0 {get;}
        public byte[] Unk2 {get;}
        public int Unk3 {get;}
    }
}