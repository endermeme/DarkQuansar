using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class DoStartWebcam : IMessage
    {
        [ProtoMember(1)]
        public int Quality { get; set; } = 50;

        [ProtoMember(2)]
        public int FrameRate { get; set; } = 10;
    }
}
