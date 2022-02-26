using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Inhouse : Part
    { 
        public int MachineID { get; set; }
        public Inhouse()
        { }
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
      
     /*    public override int PartID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set ; }
        public override int InStock { get ; set; }
        public override int Min { get ; set ; }
        public override int Max { get; set; }

   */
    }
}
