using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDeskTask1.Model
{
    class Restauant : IRestaurant
    {
        public List<ILine> Lines { get; set; }

        public List<ICustomer> Customers { get; set; }

        public void AddCustomer(ICustomer customer)
        {
            Customers.Add(customer);
        }

        public void AddLine(ILine line)
        {
            Lines.Add(line);
        }

        public void RemoveCustomer(ICustomer customer)
        {
            Customers.Remove(customer);
        }

        public void RemoveLine(ILine line)
        {
            Lines.Remove(line);
        }
    }
}
