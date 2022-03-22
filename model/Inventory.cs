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
