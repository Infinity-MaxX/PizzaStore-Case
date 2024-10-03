using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        #region Instance Field
        // private int _number;
        // private string _description;
        // private List<string> _basket;
        private string _name;
        private double _price;
        #endregion

        #region Constructor
        public Pizza(string name, double price)
        {
            // _number = 1;
            // _description = "tomato, mozarella";
            _name = name;
            _price = price;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }
        public double Price
        {
            get { return _price; }
        }
        #endregion
        
        #region Methods
        public override string ToString()
        {
            return $"Pizza: {Name}\nPrice: {Price}";
        }
        #endregion
    }
}
