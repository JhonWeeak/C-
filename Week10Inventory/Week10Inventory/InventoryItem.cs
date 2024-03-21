using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class InventoryItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // FormattedInfo property to display information with line breaks
        public string FormattedInfo => $"Item No: {ItemNo}\nDescription: {Description}\nPrice: {Price:C2}";
    }
}
