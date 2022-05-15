using System;
using System.IO;
using System.Linq;
using System.Text;
using LostArk.Game.Messages.Structures;

namespace LostArk.Game.Messages.Types
{
    public struct LostArkString
    {
        public LostArkString(NameString data)
        {
            bool unicode;
            if (data.Unk0 == data.Unk0_0.Length)
            {
                unicode = true;
            }
            else if (2 * data.Unk0 == data.Unk0_0.Length)
            {
                unicode = false;
            }
            else
            {
                throw new Exception(
                    $"String buffer size mismatch length header. Header: {data.Unk0}, buffer: {data.Unk0_0.Length}");
            }

            Value = unicode ? Encoding.Unicode.GetString(data.Unk0_0) : Encoding.UTF8.GetString(data.Unk0_0);
        }

        public string Value { get; }
    }
}