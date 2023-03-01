using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchasingSystem
{
    class Phone
    {
        public string firstName;
        public string lastName;
        public string phoneBrand;
        public string operatingSystem;
        public int ramSize;
        public int phonePrice;
        public int balance;

        public Phone(string firstName, string lastName, string phoneBrand, string operatingSystem, int ramSize, int phonePrice)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneBrand = phoneBrand;
            this.operatingSystem = operatingSystem;
            this.ramSize = ramSize;
            this.phonePrice = phonePrice;
        }

        public void showPersonalInformations()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Balance: " + balance);
        }

        public void showPhoneInformations()
        {
            Console.WriteLine("Operating System: " + operatingSystem);
            Console.WriteLine("Phone Brand: " + phoneBrand);
            Console.WriteLine("Ram Size: " + ramSize);
            Console.WriteLine("Phone Price: " + phonePrice);
        }

        public void checkAffordability()
        {
            if (balance >= phonePrice)
            {
                Console.WriteLine("You have enough money.");
                Console.WriteLine("You can buy this phone!");
            }

            else
            {
                Console.WriteLine("You do not have enough money.");
                Console.WriteLine("You can not buy this phone!");
            }
        }
    }
}
