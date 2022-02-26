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

        public Product(BindingList<Part> associatedParts,int productID, string name, Decimal price, int stock, int min, int max)
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
        public BindingList<Part> AssociatedParts { get; set; }


      
        public void addAssociatedPart()
        {

        }
        public bool removeAssociatedPart()
        {
            return true;
        }
        public int lookupAssociatedPart()
        {
            return ProductID;
        }
    }
}
