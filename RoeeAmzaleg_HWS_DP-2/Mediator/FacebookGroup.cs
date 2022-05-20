using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2.Mediator
{
    public class FacebookGroup : IFacebookGroup
    {
        private readonly List<IMember> members = new List<IMember>();
        public void RegisterMember(IMember member)
        {
            members.Add(member);
        }
        public void SendMessage(string message, IMember member)
        {
            foreach (IMember m in members)
                if (m != member) m.Receive(message);
        }
    }
}
