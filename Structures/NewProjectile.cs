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
    public class NewProjectile
    {
        public bool valid = false;

        internal NewProjectile()
        {
            //Made for conditional structures
        }

        internal NewProjectile(LostArkMessageReader reader)
        {
            valid = true;
            Unk0 = reader.ReadByte();
            Unk1 = reader.ReadInt16();
            Owner = reader.ReadInt64();
            Unk3 = reader.ReadInt64();
            Unk4 = reader.ReadInt64();
            Unk5 = reader.ReadInt32();
            Unk6 = reader.ReadByte();
            if(Unk6 == 1)
            {
                Struct_269_0 = new Struct_269(reader);
            }
            Unk7 = reader.ReadInt32();
            Unk8 = reader.ReadBytes(6);
            Id = reader.ReadInt64();
            Unk10 = reader.ReadByte();
            SkillId = reader.ReadInt32();
            Unk12 = reader.ReadInt16();
            Unk13 = reader.ReadInt64();
            Unk14 = reader.ReadByte();
            if(Unk14 == 1)
            {
                Unk14_0 = reader.ReadInt32();
            }

            SkillEffect = reader.ReadInt32();
            Unk16 = reader.ReadInt32();
            Tripods = reader.ReadBytes(3);
            SkillLvl = reader.ReadByte();
        }

        public byte Unk0 {get;}
        public short Unk1 {get;}
        public long Owner { get; }
        public long Unk3 {get;}
        public long Unk4 {get;}
        public int Unk5 {get;}
        public byte Unk6 {get;}
        public Struct_269 Struct_269_0 {get;} = new Struct_269();
        public int Unk7 {get;}
        public byte[] Unk8 {get;}
        public long Id { get; }
        public byte Unk10 {get;}
        public int SkillId { get; }
        public short Unk12 {get;}
        public long Unk13 {get;}
        public byte Unk14 {get;}
        public int Unk14_0 {get;}
        public int SkillEffect { get; }
        public int Unk16 {get;}
        public byte[] Tripods { get; }
        public byte SkillLvl { get; }
    }
}