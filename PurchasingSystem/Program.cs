using System;
using System.Runtime.ConstrainedExecution;

namespace PurchasingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("PLEASE CHOOSE FROM ONE OF THE FOLLOWING OPTIONS");
                Console.WriteLine("1. Personel Informations");
                Console.WriteLine("2. Phone Informations");
                Console.WriteLine("3. Check Affordability");
                Console.WriteLine("4. Exit");
            }

            Phone phoneInstance = new Phone("Emin", "Tatar", "Huawei", "Android", 8, 5000);

            int option = 0;

            while (option != 4)
            {
                printOptions();

                try
                {
                    option = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:" + e);
                }

                if (option == 1)
                {
                    phoneInstance.showPersonalInformations();
                }

                else if (option == 2)
                {
                    phoneInstance.showPhoneInformations();
                }

                else if (option == 3)
                {
                    Console.Write("Enter your current balance: ");
                    phoneInstance.balance = int.Parse(Console.ReadLine());
                    phoneInstance.checkAffordability();
                }

                else if (option == 4)
                {
                    break;
                }

                else
                {
                    option = 0;
                }

            }

            Console.WriteLine("Thank You!");
            Console.WriteLine("Have a Nice Day :)");
        }
    }
}
