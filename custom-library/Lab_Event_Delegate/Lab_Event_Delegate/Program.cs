//Khai bao phuong thuc xuat danh sach mat hang ra man hinh
using Lab_Event_Delegate;
using System.Collections;
using static Lab_Event_Delegate.Product;

namespace Lab_Event_Delegate
{
    class Program
    {
        static void PrintProduct(ArrayList al)
        {

            foreach (Product p in al)
            {
                Console.WriteLine("ProductID:" + p.ProductID);
                Console.WriteLine("ProductName:" + p.ProductName);
                Console.WriteLine("UnitPrice:" + p.UnitPrice);
                Console.WriteLine("Quanity:" + p.Quantity);
                Console.WriteLine("SubTotal:" + p.SubTotal);
                Console.WriteLine("-------------------------------------");
            }
        }

        //Khai bao phuong thuc xuat thong bao sau khi xoa mat hang
        static void DisplayMessageForRemoveProduct(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {


            //Tao cac doi tuong Product su dung 0bject Initializer
            Product objCaphe = new Product
            {

                ProductID = 1,
                ProductName = "caphe",
                Quantity = 12,
                UnitPrice = 3


            };

            Product objMilk = new Product
            {
                ProductID = 2,
                ProductName = "milk",
                UnitPrice = 23,
                Quantity = 4

            };

            //Khai bao doi tuong ManageProduct de thục hien them , xoa , tim product
            ManageProduct mp = new ManageProduct();

            //dang ky su kien khi xoa mat hang trong danh sach.

            //khi su kien EventAddProduct cua doi tuong mp phat sinh no se goi

            //den phuong thuc Displ]ayMessageForRemoveProduct de xuat thong bao
            mp.EventAddProduct += new WarningDelegate(DisplayMessageForRemoveProduct);
            //Them cac mat hang vao ArrayList thong qua phuong thuc AddNew

            mp.AddNew(objCaphe);
            mp.AddNew(objMilk);

            Console.WriteLine("********* Danh sach cac mat hang *********");
            //Xem danh sach cac mat hang

            PrintProduct(mp.GetProductList);

            //Tim mat hang co ProductID = 1

            Console.WriteLine("********* Tim mat hang theo ProductTDXXX *********");
            Console.Write("Enter productID = ");

            int proID = int.Parse(Console.ReadLine());

            Product p = mp.Find(proID);

            if (p != null)
            {
                //xoa mat hang nay khi tim thay
                mp.Remove(p.ProductID);
                Console.Write("Press enter to review product list:");
                Console.ReadLine();
                PrintProduct(mp.GetProductList);
            }
            else
            {
                Console.WriteLine("Product not found.");

            }
        }
    }
}

