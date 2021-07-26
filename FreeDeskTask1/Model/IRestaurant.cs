using System.Collections.Generic;

namespace FreeDeskTask1.Model
{
    interface IRestaurant
    {
        public void AddLine(ILine line);
        
        public void RemoveLine(ILine line);

        public void AddCustomer(ICustomer customer);
        
        public void RemoveCustomer(ICustomer customer);

        public List<ILine> Lines { get; }

        public List<ICustomer> Customers { get; }
    }
}
