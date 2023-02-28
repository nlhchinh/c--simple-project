using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Medicine
    {
        private string code;
        private string name;
        private string manufacturer;
        private int price;
        private int quantity;
        private string date;
        private string expireDate;
        private int batchNumber;

        public Medicine()
        {
          Code =null;
          Name =null;
          Manufacturer =null;
          Price = 0;
          Quantity = 0;
          Date = null;
          ExpireDate = null;
          BatchNumber = 0;
    }

        public Medicine(string code, string name, string manufacturer, int price, int quantity, string date, int batchNumber, string expireDate)
        {   
            this.Code = code;
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Quantity = quantity;
            this.Date = date;
            this.ExpireDate = expireDate;
            this.BatchNumber = batchNumber;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Date { get => date; set => date = value; }
        public string ExpireDate { get => expireDate; set => expireDate = value; }
        public int BatchNumber { get => batchNumber; set => batchNumber = value; }

        public void Accept()
        {
            Console.WriteLine("Enter the medicine code:");
            Code = Console.ReadLine();
            Console.WriteLine("Enter the medicine name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the medicine manufacturer:");
            Manufacturer = Console.ReadLine();
            Console.WriteLine("Enter the medicine price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the medicine quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the medicine date:");
            date = Console.ReadLine();
            Console.WriteLine("Enter the medicine expireDate:");
            ExpireDate = Console.ReadLine();
            Console.WriteLine("Enter the medicine batchNumber:");
            batchNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void IncreaseQuantity()
        {
            Quantity +=50;
        }

        public void Print()
        {
            Console.WriteLine("\n***** Medicine detail *****");
            Console.WriteLine("Medicine code:" + Code);
            Console.WriteLine("Medicine name:" + Name);
            Console.WriteLine("Manufacturer name:" + Manufacturer);
            Console.WriteLine("The unit price:" + Price);
            Console.WriteLine("The quantity on hand:" + Quantity);
            Console.WriteLine("The manufactured date:" + Date);
            Console.WriteLine("The expiry date:" + ExpireDate);
            Console.WriteLine("The batch number:" + BatchNumber);
        }

        public void Print(string code)
        {
            Console.WriteLine("Medicine code:" + code);
            Console.WriteLine("The quantity on hand:" + Quantity);
        }

        public void Print(string code, string name)
        {
            Console.WriteLine("Medicine code:" + code);
            Console.WriteLine("Medicine name:" + name);
            Console.WriteLine("The expiry date:" + ExpireDate);
            Console.WriteLine("The manufactured date: :" + Date);
        }

    }
}
