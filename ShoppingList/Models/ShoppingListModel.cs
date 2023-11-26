using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class ShoppingListModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<ItemModel> items { get; set; }
    }
}
