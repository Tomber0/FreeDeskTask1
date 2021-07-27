using FreeDeskTask1.View;
using System;
using System.Collections;
using System.Linq;

namespace FreeDeskTask1.Model
{
    class Customer : ICustomer
    {
        public string Name { get; private set; }

        Printer printer = new ConsolePrinter();

        public delegate void PrintMessage(string message);

        public event PrintMessage OnPrintMessage;

        public IRestaurant Restaurant { get => _restaurant; private set => _restaurant = value; }

        private int _counter = 1000000;

        private ILine _line;

        public ILine Line
        {
            get
            {
                return _line;
            }
            private set
            {
                _line = value;
            }
        }

        private int _queuePosition;

        private IRestaurant _restaurant;

        public int QueuePosition
        {
            get
            {
                return _queuePosition;
            }
            private set
            {
                if (value >= 0)
                {
                    _queuePosition = value;

                }
                else
                {
                    throw new Exception($"{nameof(QueuePosition)} is {value}, {nameof(QueuePosition)} can't be lower than 0 !");
                }
            }
        }

        public void ExitFromLine()
        {
            Line = null;
        }

        public ILine FindABetterLine(ILine[] lines)
        {
            int minCustomers = QueuePosition;
            ILine newLine = null;
            foreach (var line in lines.Where(l => l!=Line))
            {
                if (line.Customers.Count<minCustomers)
                {
                    newLine = line;
                }
            }
            return newLine;
        }

        public void MoveToLine(ILine line)
        {
            if (line != null)
            {
                Line = line;
                Line.AddCustomer(this);

                TryMovePosition(Line.Customers.Count);
            }
            else
            {
                throw new Exception($"{nameof(line)} is null !");
            }
        }

        public void Run()
        {
            while (_counter > 0)
            {

                _counter--;
            }
        }

        public bool Swap(ICustomer customer)
        {
            OnPrintMessage($"{Name} trying to swap with {customer.Name}");
            customer.TryMovePosition(QueuePosition);
            TryMovePosition(customer.QueuePosition);
            return true;
        }

        public bool TryMovePosition(int position)
        {
            OnPrintMessage($"{Name} trying to move into {position} position");
            try
            {
                QueuePosition = position;
                OnPrintMessage($"{Name} moved into {position}");
                return true;
            }
            catch (Exception ex)
            {
                OnPrintMessage(ex.Message);
                return false;
            }
        }
    }
}
