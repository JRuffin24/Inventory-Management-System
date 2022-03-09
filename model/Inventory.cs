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
        //    Product product = new Product();
        //    Inventory inventory = new Inventory(Products, AllParts);

        //    Inhouse part1 = new Inhouse();
        //    part1.Name = "nuts";
        //    part1.PartID = 1;
        //    part1.InStock = 3;
        //    part1.Price = 3.75m;
        //    part1.Max = 3;
        //    part1.Min = 0;
        //    part1.MachineID = 2;
        //    AllParts.Add(part1);

        //    Inhouse part2 = new Inhouse();
        //    part2.Name = "bolts";
        //    part2.PartID = 2;
        //    part2.InStock = 33;
        //    part2.Price = 0.75m;
        //    part2.Max = 23;
        //    part2.Min = 3;
        //    part2.MachineID = 3;
        //    AllParts.Add(part2);

        //    Outsourced outsourcedPart = new Outsourced();
        //    outsourcedPart.Name = "screws";
        //    outsourcedPart.PartID = 3;
        //    outsourcedPart.Price = 1.05m;
        //    outsourcedPart.InStock = 40;
        //    outsourcedPart.Max = 10;
        //    outsourcedPart.Min = 2;
        //    outsourcedPart.CompanyID = 101;
        //    AllParts.Add(outsourcedPart);

        //    Outsourced outsourcedPart2 = new Outsourced();
        //    outsourcedPart2.Name = "washers";
        //    outsourcedPart2.PartID = 4;
        //    outsourcedPart2.Price = 1.05m;
        //    outsourcedPart2.InStock = 100;
        //    outsourcedPart2.Max = 10;
        //    outsourcedPart2.Min = 2;
        //    outsourcedPart2.CompanyID = 231;
        //    AllParts.Add(outsourcedPart2);

        //    product.Name = "Bike";
        //    product.ProductID = 1;
        //    product.Price = 20.00m;
        //    product.Max = 3;
        //    product.Min = 0;
        //    product.InStock = 20;
        //    Products.Add(product);

        //    Product product2 = new Product();
        //    product2.Name = "Tricycle";
        //    product2.ProductID = 2;
        //    product2.Price = 30.00m;
        //    product2.Max = 4;
        //    product2.Min = 1;
        //    product2.InStock = 30;
        //    Products.Add(product2);
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
                    
                    //if(item.Name != part.Name)
                    //{
                    //    item.Name = part.Name;
                    //}

                }
            }
        }
        public void deletePart(Part part)
        {

        }
        public void lookupPart(Part part)
        {
            //Part part1 = AllParts.SingleOrDefault(p => p.PartID == partSearchTextBox.Text);
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
