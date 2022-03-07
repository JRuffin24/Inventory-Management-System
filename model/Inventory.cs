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
        public void updatePart(int partID, Part part)
        {
            foreach (Part item in AllParts)
            {
                if (item.PartID == partID)
                {
                    if(item.Name != part.Name)
                    {
                        item.Name = part.Name;
                    }

                }
            }
        }
        public void deletePart(Part part)
        {

        }
        public void lookupPart(Part part)
        {

        }
        public void deleteProduct(int productID)
        {

        }
        public void lookupProduct(int productID)
        {

        }

        public void updateProduct(int productID, Product product)
        {

        }
    }
}
