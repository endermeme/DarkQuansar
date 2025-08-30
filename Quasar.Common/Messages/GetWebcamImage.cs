using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class GetWebcamImage : IMessage
    {
        [ProtoMember(1)]
        public int Quality { get; set; } = 50;
    }
}
