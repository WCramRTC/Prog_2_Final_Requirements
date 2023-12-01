using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_Final_Requirements
{
    public class Department
    {
        string _name;
        List<InventoryItem> _inventory;

        public Department(string name)
        {
            _name = name;
            _inventory = new List<InventoryItem>();
        }

        public string Name { get => _name; set => _name = value; }
        public List<InventoryItem> Inventory { get => _inventory; set => _inventory = value; }

        public void AddItem(InventoryItem item)
        {
            _inventory.Add(item);
        }

        public override string ToString()
        {
            return $"{_name}";
        }


    } // class

} // namespace
