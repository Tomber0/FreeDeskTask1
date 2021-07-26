using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDeskTask1.Model
{
    class Restauant : IRestaurant
    {
        public List<ILine> Lines => throw new NotImplementedException();

        public List<ICustomer> Customers => throw new NotImplementedException();

        public void AddCustomer(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void AddLine(ILine line)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveLine(ILine line)
        {
            throw new NotImplementedException();
        }
    }
}
