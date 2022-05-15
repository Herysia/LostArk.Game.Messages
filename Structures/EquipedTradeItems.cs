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
    public class EquipedTradeItems
    {
        public bool valid = false;

        internal EquipedTradeItems()
        {
            //Made for conditional structures
        }

        internal EquipedTradeItems(LostArkMessageReader reader)
        {
            valid = true;
            Count = reader.ReadInt16();
            if (Count <= 9)
            {
                for (var i = 0; i < Count; i++)
                {
                    Items.Add(new EquipedItem(reader));
                }
            }
        }

        public short Count { get; }
        public List<EquipedItem> Items { get; } = new List<EquipedItem>();
    }
}