using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_2_Final_Requirements
{
    public class InventoryItem
    {
        // Fields
        string _sku;
        string _name;
        double _price;
        bool _inStock;

        public InventoryItem(string sku, string name, double price, bool inStock)
        {
            _sku = sku;
            _name = name;
            _price = price;
            _inStock = inStock;
        }
        // Properties
        public string Sku { get => _sku; set => _sku = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public bool InStock { get => _inStock; set => _inStock = value; }

        // Method
        // public string DisplayInformation() 
        public string DisplayInformation()
        {
            // Product Name: {_name}
            // ---------------------
            // Product Description : {_description}
            // Price : {_price.ToString("c");}
            // In Stock : {_inStock}

            string fullDisplay = ""; // ""
            fullDisplay += $"Product Name: {_name}\n";
            fullDisplay += $"----------------------\n";
            fullDisplay += $"Product Sku: {_sku}\n";
            fullDisplay += $"Product Price: {_price.ToString("c")}\n";
            fullDisplay += $"In Stock: {_inStock}\n";

            return fullDisplay;
        }


        // Shortcuts

  


        // Constructor
        // public InventoryItem(paremeters)
        //public InventoryItem(string sku, string name, double price, bool inStock)
        //{
        //    _sku = sku;
        //    _name = name;
        //    _price = price;
        //    _inStock = inStock;
        //}

    } // class

} // namespace
