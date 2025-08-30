using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class GetWebcamImageResponse : IMessage
    {
        [ProtoMember(1)]
        public byte[] Image { get; set; }

        [ProtoMember(2)]
        public int Quality { get; set; }

        [ProtoMember(3)]
        public bool Success { get; set; }

        [ProtoMember(4)]
        public string ErrorMessage { get; set; }
    }
}
