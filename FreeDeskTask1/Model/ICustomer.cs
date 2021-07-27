using System.Collections.Generic;

namespace FreeDeskTask1.Model
{
    interface ICustomer
    {
        public void MoveToLine(ILine line);
        
        public void ExitFromLine();

        public ILine FindABetterLine(List<ILine> lines);

        public bool Swap(ICustomer customer);

        public void Run();

        public bool TryMovePosition(int position);

        public IRestaurant Restaurant { get; }

        public int QueuePosition { get; }

        public ILine Line { get;  }

        public string Name { get; }

    }
}
