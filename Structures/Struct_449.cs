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
    public class Struct_449
    {
        public bool valid = false;
        internal Struct_449()
        {
            //Made for conditional structures
        }

        internal Struct_449(LostArkMessageReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 32)
            {
                Unk0_0 = reader.ReadBytes(2*Unk0);
            }
        }

        public short Unk0 {get;}
        public byte[] Unk0_0 {get;}
    }
}