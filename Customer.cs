using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance Field
        private string _name;
        private string _email;
        private string _phone;
        #endregion

        #region Constructor
        public Customer(string name, string email, string phone)
        {
            _name = name;
            _email = email;
            _phone = phone;
        }
        #endregion

        #region Properties
        public string Name { get { return _name; } }
        public string Email { get { return _email; } }
        public string Phone { get { return _phone; } }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Customer info:\nName: {Name}\nE-mail: {Email}\nPhone: {Phone}";
        }
        #endregion
    }
}
