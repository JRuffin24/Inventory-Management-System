using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    internal static class Program
    {
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> allParts = new BindingList<Part>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Product product = new Product();
            Inventory inventory = new Inventory(products, allParts);

            Inhouse part1 = new Inhouse();
            part1.Name = "nuts";
            part1.PartID = 1;
            part1.InStock = 3;
            part1.Price = 3.75m;
            part1.Max = 3;
            part1.Min = 0;
            allParts.Add(part1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
