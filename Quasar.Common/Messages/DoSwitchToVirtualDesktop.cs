using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class DoSwitchToVirtualDesktop : IMessage
    {
        [ProtoMember(1)]
        public string DesktopName { get; set; }
    }
}
