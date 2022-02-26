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
       // public static System.Windows.Forms.FormCollection OpenForms { get; }
        //public event Action<string> GetPartName;

       // Form form1 = Application.OpenForms["addPartForm"];
       /* public Inventory(BindingList<Product> products, BindingList<Part> allParts)
        {
            Products = products;
            AllParts = allParts;
        } */
       
      
        public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts { get; set; }


        public static void addPart(Part part)
        {
            AllParts.Add(part);           
        }

     
     
    }
}
