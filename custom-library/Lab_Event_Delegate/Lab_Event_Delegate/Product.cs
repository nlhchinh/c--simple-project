using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Event_Delegate
{
    public delegate void WarningDelegate(string message);
    public class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float SubTotal
        {
            get
            {
                return UnitPrice * Quantity;
            }

        }

        //Khai bao lop ManageProduct
        public class ManageProduct
        {
            //khai bao event dung de xuat thong bao
            //sau khi product da bi xoa
            public event WarningDelegate EventAddProduct;
            //khai bao danh sach de luu cac mat hang
            private ArrayList ProductList = new ArrayList();
            //khai bao property de danh sach mat hang
            public ArrayList GetProductList
            {
                get
                {
                    return ProductList;
                }

            }

            //khai bao phuong thuc tim product theo productTD
            public Product Find(int ProductID)
            {
                foreach (Product p in ProductList)
                {
                    if (p.ProductID == ProductID)
                        return p;

                }

                return null;
            }
            //Khai bao phuong thuc them moi product vao array list
            public void AddNew(Product p)
            {
                ProductList.Add(p);
            }

            //khai bao phuogn thuc xoa product
            public void Remove(int ProductID)
            {
                Product p = Find(ProductID);
                if (p != null)
                {
                    ProductList.Remove(p);
                    //phat su kien khi them product
                    EventAddProduct("Product ID = " + p.ProductID + " removed successful.");

                }
            }
        }
    }
}
