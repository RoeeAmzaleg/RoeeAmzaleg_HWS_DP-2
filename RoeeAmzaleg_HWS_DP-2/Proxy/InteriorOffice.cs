using RoeeAmzaleg_HWS_DP_2.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2
{
    public class InteriorOffice : IInteriorOffice
    {
        private IInteriorOffice person;

        public InteriorOffice(IInteriorOffice person)
        {
            this.person=person;
        }

        public void AddNewCitizen()
        {
            this.person.AddNewCitizen();
        }
        public void IssuingNewPassport()
        {
            this.person.IssuingNewPassport();
        }
    }
}