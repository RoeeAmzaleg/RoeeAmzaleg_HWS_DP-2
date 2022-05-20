using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2.Mediator
{
    public class Member : IMember
    {
        private readonly IFacebookGroup mediator;
        private string name;

        public Member(IFacebookGroup mediator, string name)
        {
            this.mediator=mediator;
            this.name=name;
        }

        public void Publish(string message)
        {
            Console.WriteLine($"{name} sending: {message}");
            mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }
    }
}
