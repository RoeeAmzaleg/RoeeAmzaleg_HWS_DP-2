using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2.Mediator
{
    public interface IMember
    {
        void Publish(string message);
        void Receive(string message);
    }
}
