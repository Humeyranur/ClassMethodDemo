using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.AdiSoyadi = "Hümeyra Nur TURGUT";
            customer1.Id =1;
            customer1.KrediPuani = 1850;
            customer1.MusteriAdres ="Kocaeli";

            Customer customer2 = new Customer();
            customer2.AdiSoyadi = "Hasan Paydaş";
            customer2.Id = 2;
            customer2.KrediPuani = 1700;
            customer2.MusteriAdres = "İstanbul";

            Customer customer3 = new Customer();
            customer3.AdiSoyadi = "Mine Demir";
            customer3.Id = 3;
            customer3.KrediPuani = 1300;
            customer3.MusteriAdres = "Ankara";

            Customer customer4 = new Customer(); 
            customer4.AdiSoyadi = "Fatma Özsoy";
            customer4.Id = 4;
            customer4.KrediPuani = 1250;
            customer4.MusteriAdres = "Trabzon";

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            Console.WriteLine("..................");

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            customerManager.Delete(customer4);

            Console.WriteLine("..................");

            customerManager.ToList(customer1);
            customerManager.ToList(customer2);
            customerManager.ToList(customer3);
            customerManager.ToList(customer4);
        }
    }
}
