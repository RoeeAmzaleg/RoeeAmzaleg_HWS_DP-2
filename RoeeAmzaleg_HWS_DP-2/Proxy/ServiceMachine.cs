using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2.Proxy
{
    internal class ServiceMachine : IServiceMachine
    {
        private IServiceMachine person;

        public ServiceMachine(IServiceMachine person)
        {
            this.person=person;
        }

        public void ChangeHomeAddress()
        {
            this.person.ChangeHomeAddress();
        }
        public void ChangeName()
        {
            this.person.ChangeName();
        }
        public void PassportRenewal()
        {
            this.person.PassportRenewal();
        }
    }
}
