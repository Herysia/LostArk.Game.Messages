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
    public class StatusEffects
    {
        public bool valid = false;

        internal StatusEffects()
        {
            //Made for conditional structures
        }

        internal StatusEffects(LostArkMessageReader reader)
        {
            valid = true;
            Unk0 = reader.ReadInt16();
            if(Unk0 <= 80)
            {
                for(var i = 0; i < Unk0; i++)
                {
                    Struct_601.Add(new Struct_601(reader));
                }
            }
        }

        public short Unk0 {get;}
        public List<Struct_601> Struct_601 {get;} = new List<Struct_601>();
    }
}