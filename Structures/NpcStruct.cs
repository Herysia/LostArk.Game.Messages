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
    public class NpcStruct
    {
        public bool valid = false;

        internal NpcStruct()
        {
            //Made for conditional structures
        }

        internal NpcStruct(LostArkMessageReader reader)
        {
            valid = true;
            Position = reader.ReadInt64();
            Struct_354_1 = new StatusEffects(reader);
            Unk2 = reader.ReadInt16();
            Unk3 = reader.ReadByte();
            if(Unk3 == 1)
            {
                Unk3_0 = reader.ReadByte();
            }
            Unk4 = reader.ReadByte();
            if(Unk4 == 1)
            {
                Unk4_0 = reader.ReadByte();
            }
            Unk5 = reader.ReadByte();
            if(Unk5 == 1)
            {
                Struct_269_0 = new Struct_269(reader);
            }
            Unk6 = reader.ReadByte();
            Id = reader.ReadInt32();
            Unk8 = reader.ReadByte();
            Unk9 = reader.ReadByte();
            if(Unk9 == 1)
            {
                Unk9_0 = reader.ReadByte();
            }
            Unk10 = reader.ReadByte();
            if(Unk10 == 1)
            {
                Unk10_0 = reader.ReadInt32();
            }
            Unk11 = reader.ReadByte();
            if(Unk11 == 1)
            {
                Unk11_0 = reader.ReadInt32();
            }
            Unk12 = reader.ReadByte();
            if(Unk12 == 1)
            {
                Unk12_0 = reader.ReadByte();
            }
            Unk13 = reader.ReadByte();
            Unk14 = reader.ReadByte();
            if(Unk14 == 1)
            {
                Unk14_0 = reader.ReadByte();
            }
            Unk15 = reader.ReadByte();
            if(Unk15 == 1)
            {
                Struct_214_0 = new Struct_214(reader);
            }

            Struct_316_25 = new CombatResources(reader);
            Unk17 = reader.ReadByte();
            if(Unk17 == 1)
            {
                Unk17_0 = reader.ReadByte();
            }
            Unk18 = reader.ReadByte();
            if(Unk18 == 1)
            {
                Unk18_0 = reader.ReadInt32();
            }
            Unk19 = reader.ReadByte();
            if(Unk19 == 1)
            {
                Unk19_0 = reader.ReadInt32();
            }
            Unk20 = reader.ReadByte();
            GameId = reader.ReadInt64();
            Unk22 = reader.ReadInt16();
            Unk23 = reader.ReadByte();
            if(Unk23 == 1)
            {
                Unk23_0 = reader.ReadInt64();
            }
            Unk24 = reader.ReadByte();
            if(Unk24 == 1)
            {
                Unk24_0 = reader.ReadInt16();
            }
            Struct_44_39 = new Struct_44(reader);
            Unk26 = reader.ReadInt32();
            Unk27 = reader.ReadByte();
            Unk28 = reader.ReadByte();
            if(Unk28 == 1)
            {
                Unk28_0 = reader.ReadInt32();
            }
            Unk29 = reader.ReadByte();
            if(Unk29 == 1)
            {
                Unk29_0 = reader.ReadInt16();
            }
            Unk30 = reader.ReadByte();
            Unk31 = reader.ReadByte();
            if(Unk31 == 1)
            {
                Unk31_0 = reader.ReadByte();
            }
        }

        public long Position { get; }
        public StatusEffects Struct_354_1 { get; } = new StatusEffects();
        public short Unk2 {get;}
        public byte Unk3 {get;}
        public byte Unk3_0 {get;}
        public byte Unk4 {get;}
        public byte Unk4_0 {get;}
        public byte Unk5 {get;}
        public Struct_269 Struct_269_0 {get;} = new Struct_269();
        public byte Unk6 {get;}
        public int Id { get; }
        public byte Unk8 {get;}
        public byte Unk9 {get;}
        public byte Unk9_0 {get;}
        public byte Unk10 {get;}
        public int Unk10_0 {get;}
        public byte Unk11 {get;}
        public int Unk11_0 {get;}
        public byte Unk12 {get;}
        public byte Unk12_0 {get;}
        public byte Unk13 {get;}
        public byte Unk14 {get;}
        public byte Unk14_0 {get;}
        public byte Unk15 {get;}
        public Struct_214 Struct_214_0 {get;} = new Struct_214();
        public CombatResources Struct_316_25 { get; } = new CombatResources();
        public byte Unk17 {get;}
        public byte Unk17_0 {get;}
        public byte Unk18 {get;}
        public int Unk18_0 {get;}
        public byte Unk19 {get;}
        public int Unk19_0 {get;}
        public byte Unk20 {get;}
        public long GameId { get; }
        public short Unk22 {get;}
        public byte Unk23 {get;}
        public long Unk23_0 {get;}
        public byte Unk24 {get;}
        public short Unk24_0 {get;}
        public Struct_44 Struct_44_39 {get;} = new Struct_44();
        public int Unk26 {get;}
        public byte Unk27 {get;}
        public byte Unk28 {get;}
        public int Unk28_0 {get;}
        public byte Unk29 {get;}
        public short Unk29_0 {get;}
        public byte Unk30 {get;}
        public byte Unk31 {get;}
        public byte Unk31_0 {get;}
    }
}