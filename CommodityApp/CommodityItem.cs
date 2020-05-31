//Grading ID here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityApp
{
    public class CommodityItem
    {
        private string _description;
        private string _productnumber;
        private int _quantity;
        private double _price;
        // #1 - Put needed backing fields here
        // Remember: Some properties may be
        // auto-implemented, so only create
        // backing fields for ones needed

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
            // #2 - Put your code here for get/set accessors
            // May be auto-implemented

        }

        public string ProductNumber
        {
            get
            {
                return _productnumber;
            }
            set
            {
                _productnumber = value;
            }
            // #3 - Put your code here for get/set accessors
            // May be auto-implemented

        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value > 0)
                    _quantity = value;
                else
                    _quantity = 0;
            }
            // #4 - Put your code here for get/set accessors
            // Set must validate!

        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
                else
                _price = 0;
            }
            // #5 - Put your code here for get/set accessors
            // Set must validate!

        } 

        public CommodityItem(string desc, string productNum, int quant, double price)
        {
            Description = desc;
            ProductNumber = productNum;
            Quantity = quant;
            Price = price;
            // #6 - Put your code here for constructor
            // Be sure your parameters get validated through properties

        }

        public double CalcValue()
        {

            
            double total;

           total =  Quantity * Price;
            return total;
            // #7 - Put your code here to calculate value of
            // this item in inventory
            // Example: 2000 @ $9.99 = $19,980

        }

        public override string ToString()
        {

            return $"{ProductNumber} {Description} ({Quantity} {Price:C})";
            // #8 - Put your code here to create formatted string
            // Use format that would produce a string like:
            // "TP1234: Toilet Papers (2500 @ $29.99)"
            // where TP1234 is the prodcut number, Toilet Paper is the
            // description, 2500 is the quantity, and $29.99 is
            // the price. No newlines are needed.


        }
    }
}
