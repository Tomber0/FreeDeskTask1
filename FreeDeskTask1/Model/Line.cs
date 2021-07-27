using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDeskTask1.Model
{
    class Line : ILine
    {
        public List<ICustomer> Customers { get => _customers; private set { _customers = value; } }

        public string Name { get; }

        private List<ICustomer> _customers = new List<ICustomer>();

        public void AddCustomer(ICustomer customer)
        {
            _customers.Add(customer);
            
        }

        public void RemoveCustomer(ICustomer customer)
        {
            _customers.Remove(customer);
        }

        public void ServeACustomer(ICustomer customer)
        {
            //custumer served
            RemoveCustomer(customer);
            PushLine();
        }
        public void PushLine() 
        {
            foreach (var customer in Customers)
            {
                customer.TryMovePosition(customer.QueuePosition-1);
            }
        }
    }
}
