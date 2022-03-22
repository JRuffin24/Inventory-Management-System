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

        public int ProductID {get;set;}
        public string Name {get;set;}
        public decimal Price {get; set;}
        public int InStock { get; set;}
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public static int CurrentIndexUpper { get; set; }
        public static int CurrentIndexLower { get; set; }
        
      
        public void addAssociatedPart(Part part)
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
