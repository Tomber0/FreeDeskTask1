using System.Collections.Generic;

namespace FreeDeskTask1.Model
{
    interface ILine
    {
        public void ServeACustomer(ICustomer customer);

        public void AddCustomer(ICustomer customer);
        
        public void RemoveCustomer(ICustomer customer);

        public List<ICustomer> Customers { get; }

        public string Name { get; }

        public void PushLine();
    }
}
