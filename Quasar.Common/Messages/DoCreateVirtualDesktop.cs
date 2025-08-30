using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class DoCreateVirtualDesktop : IMessage
    {
        [ProtoMember(1)]
        public string StationName { get; set; }

        [ProtoMember(2)]
        public string DesktopName { get; set; }
    }
}
