using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_2.Proxy
{
    public class Person : IServiceMachine, IInteriorOffice
    {
        private readonly List<Person> persons = new List<Person>();
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Id { get; set; }
        public int PassportNumber { get; set; }

        public Person(string fullName, string id,  string address, int passportNumber)
        {
            FullName=fullName;
            Id=id;
            Address=address;
            PassportNumber=passportNumber;
        }

        public void AddNewCitizen()
        {   
            Console.WriteLine($"\nWelcome {FullName} you now a citizen of our country .\nYour Id is: {Id}");
        }

        public void ChangeHomeAddress()
        {
            Console.WriteLine($"Your new adress is: {Address} !");
        }

        public void ChangeName()
        {
            Console.WriteLine($"Your name has been successfully replaced!");                
        }

        public void IssuingNewPassport()
        {
            Console.WriteLine($"Congratulation !!! You have received your new passport. No': {PassportNumber}");
        }

        public void PassportRenewal()
        {
            Console.WriteLine("your passport is renewed !");
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
