using RoeeAmzaleg_HWS_DP_2.Mediator;
using RoeeAmzaleg_HWS_DP_2.Proxy;
using System;
using System.Collections.Generic;

namespace RoeeAmzaleg_HWS_DP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mediator
            Console.WriteLine("****** Mediator ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            IFacebookGroup mediator = new FacebookGroup();
            var member1 = new Member(mediator, "roee");
            var member2 = new Member(mediator, "avivit");
            var member3 = new Member(mediator, "dani");

            mediator.RegisterMember(member1);
            mediator.RegisterMember(member2);
            mediator.RegisterMember(member3);

            Console.ForegroundColor = ConsoleColor.Cyan;
            member1.Publish("\nhello, i'm roee. nice to meet you");
            Console.ForegroundColor = ConsoleColor.Yellow;
            member2.Publish("\nhello, i'm avivit. nice to meet you");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            member3.Publish("\nhello, i'm dani. nice to meet you");
            #endregion

            #region Proxy
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****** Proxy ******");

            Person p1 = new Person("Post Malone", "0345698", "Dizingof 130 Tel Aviv", 1145899);
            Person p2 = new Person("Kanye West", "0054895", "Hertzel 7 Petah Tikva", 1158963);
            Person p3 = new Person("Joyner Lucas", "0185236", "Bialik 20 Ramat Gan", 1110204);
            Person p4 = new Person("French Montana", "0363998", "Havradim 33 Haifa", 1178555);

            var interiorOffice = new InteriorOffice(p1);
            var interiorOffice2 = new InteriorOffice(p2);
            var interiorOffice3 = new InteriorOffice(p3);
            var interiorOffice4 = new InteriorOffice(p4);


            var serviceMachine = new ServiceMachine(p1);
            var serviceMachine2 = new ServiceMachine(p2);
            var serviceMachine3 = new ServiceMachine(p3);
            var serviceMachine4 = new ServiceMachine(p4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            PersonInformation(interiorOffice, serviceMachine);
            Console.ForegroundColor = ConsoleColor.Yellow;
            PersonInformation(interiorOffice2, serviceMachine2);
            Console.ForegroundColor = ConsoleColor.Green;
            PersonInformation(interiorOffice3, serviceMachine3);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            PersonInformation(interiorOffice4, serviceMachine4);

            static void PersonInformation(IInteriorOffice Office, IServiceMachine Machine)
            {
                Office.AddNewCitizen();
                Machine.ChangeHomeAddress();
                Office.IssuingNewPassport();
                Machine.PassportRenewal();
                Machine.ChangeName();
            }
            #endregion

        }
    }
}
