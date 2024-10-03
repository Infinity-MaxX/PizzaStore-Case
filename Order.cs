using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Order
    {
        private static int counter = 0;
        #region Instance Field
        private Customer _customer;
        private Pizza _pizza;
        private int _orderNo;
        #endregion

        #region Constructor
        public Order(Customer customer, Pizza pizza)
        {
            _customer = customer;
            _pizza = pizza;
            counter++;
            _orderNo = counter;
        }
        #endregion

        #region Properties
        public Customer Customer { get { return _customer; } }
        public Pizza Pizza { get { return _pizza; } }
        public int OrderNo { get { return _orderNo; } }
        #endregion

        #region Methods
        public double TotalPrice()
        {
            double shipping = 40.0;
            double tax = 1.25;
            return (_pizza.Price + shipping) * tax;
        }
        public override string ToString()
        {
            return $"Order number: {_orderNo}\n" +
                $"{Customer}\n{Pizza}\n" +
                $"Total price: {TotalPrice()}";
        }
        #endregion
    }

}
