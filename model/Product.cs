using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Product
    {
        public Product() { }

        public Product(BindingList<Part> associatedParts, int productID, string name, Decimal price, int stock, int min, int max)
        {
            AssociatedParts = associatedParts;

            ProductID = productID;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }
        public int ProductID {get;set;}
        public string Name {get;set;}
        public decimal Price {get; set;}
        public int InStock { get; set;}
        public int Min { get; set; }
        public int Max { get; set; }
        public static BindingList<Part> AssociatedParts { get; set; }
        public static int CurrentIndexUpper { get; set; }
        public static int CurrentIndexLower { get; set; }

      
        public static void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
        public Part lookupAssociatedPart(int partID)
        {
            foreach(Part part in AssociatedParts)
            {
                if(part.PartID == partID)
                {
                    return part;
                }
            }
            Inhouse emptyInHousePart = new Inhouse();
            return emptyInHousePart;
        }
    }
}
