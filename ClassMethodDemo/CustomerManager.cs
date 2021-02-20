using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri başarı ile eklendi:"+ " " + customer.AdiSoyadi);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri adres bilgileri başarı ile silindi :" + " " + customer.MusteriAdres);
        }

        public void ToList(Customer customer)
        {
            Console.WriteLine("Müşteri kredi puanına göre listelendi:" + " " + customer.KrediPuani);
        }
    }
}
