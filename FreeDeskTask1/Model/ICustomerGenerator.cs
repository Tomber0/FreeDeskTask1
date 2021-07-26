using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDeskTask1.Model
{
    interface ICustomerGenerator
    {
        public ICustomer GenerateCustomer();
    }
}
