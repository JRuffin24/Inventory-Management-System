using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    
    public class Inventory
    {
       
        public Inventory(BindingList<Product> products, BindingList<Part> allParts)
        {
            Products = products;
            AllParts = allParts;
        } 
            
        public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts { get; set; }


        public static void loadSampleData()
        {
            

            //Product product1 = new Product();
            //product1.Name = "Bike";
            //product1.ProductID = 1;
            //product1.Price = 20.00m;
            //product1.Max = 3;
            //product1.Min = 0;
            //product1.InStock = 20;
            //Products.Add(product1);

            //Product product2 = new Product();
            //product2.Name = "Tricycle";
            //product2.ProductID = 2;
            //product2.Price = 30.00m;
            //product2.Max = 4;
            //product2.Min = 1;
            //product2.InStock = 30;
            //Products.Add(product2);

            

            //Inhouse part1 = new Inhouse(1,"nuts", 3.75m, 3, 0, 3, 1);
            //Inhouse part2 = new Inhouse(2, "bolts", 0.75m, 32, 3, 23, 2);
            //Outsourced part3 = new Outsourced(3, "screws", 1.05m, 40, 2, 10, 101);
            //Outsourced part4 = new Outsourced(4, "washers", 1.15m, 100, 2, 10, 231);

            
            
            //AllParts.Add(part1);
            //AllParts.Add(part2);
            //AllParts.Add(part3);
            //AllParts.Add(part4);



        }

        public static void addPart(Part part)
        {
            AllParts.Add(part);           
        }
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static void updatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;

                }

            }
            
        }
        public static bool deletePart(int part)
        {
            Part partToDelete = lookupPart(part);
            if(partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }
        public static Part lookupPart(int partID)
        {
            foreach(Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }

            }
            Part emptyPart = new Inhouse();
            return emptyPart;
           
        }
        public static bool removeProduct(int productID)
        {
            bool successfulRemove = false;
            foreach(Product product in Products)
            {
                if(productID == product.ProductID)
                {
                    Products.Remove(product);
                    return successfulRemove = true;
                }
                else
                {
                    MessageBox.Show("Error: Removal unsuccessful.");
                    return successfulRemove = false;
                }
            }
            return successfulRemove;
        }
        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }

            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }

        public static void updateProduct(int productID, Product product)
        {

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = product;

                }

            }
        }
    }
}
