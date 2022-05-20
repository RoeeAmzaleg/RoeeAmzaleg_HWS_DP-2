using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2.Mediator
{
    public interface IFacebookGroup
    {
        void SendMessage(string message, IMember user);
        void RegisterMember(IMember member);
    }
}
