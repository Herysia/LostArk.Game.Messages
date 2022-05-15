using System;
using System.Diagnostics;
using System.Reflection.Emit;
using LostArk.Game.Messages.Services;

namespace LostArk.Game.Messages
{
    // Base class for parsed messages
    public abstract class ParsedMessage : Message
    {
        internal ParsedMessage(LostArkMessageReader reader)
            : base(reader.Message.Time, reader.Message.Direction, reader.Message.Data)
        {
            Raw = reader.Message.Payload;
        }

        public byte[] Raw { get; protected set; }


        public void PrintRaw()
        {
            Debug.WriteLine(GetRawString());
        }

        public string GetRawString()
        {
            var s = "";
            s += String.Format("{0} ({1}) {2} ({3}) {4}", OpCode,
                Direction == MessageDirection.ClientToServer ? "->" : "<-", Data.Length,
                BitConverter.ToString(Payload).ToLower().Replace("-", ""));
            return s;
        }
    }
}