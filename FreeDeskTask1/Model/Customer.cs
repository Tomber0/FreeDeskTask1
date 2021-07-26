using System;
using System.Collections;

namespace FreeDeskTask1.Model
{
    class Customer : ICustomer
    {
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

        private int _qeuePosition;

        private IRestaurant _restaurant;

        public int QeuePosition
        {
            get
            {
                return _qeuePosition;
            }
            set
            {
                if (value >= 0)
                {
                    _qeuePosition = value;

                }
                else
                {
                    throw new Exception($"{nameof(QeuePosition)} is {value}, {nameof(QeuePosition)} can't be lower than 0 !");
                }
            }
        }

        public void ExitFromLine()
        {
            Line = null;
        }

        public bool FindABetterLine(ILine[] lines)
        {
            throw new System.NotImplementedException();
        }

        public void MoveToLine(ILine line)
        {
            if (line != null)
            {
                Line = line;
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

            return true;
        }

        public bool MovePosition(int position)
        {
            try
            {
                QeuePosition = position;
                return true;
            }
            catch (Exception ex)
            {
                   
                return false;
            }
        }
    }
}
