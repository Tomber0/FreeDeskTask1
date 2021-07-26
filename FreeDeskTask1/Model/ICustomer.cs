namespace FreeDeskTask1.Model
{
    interface ICustomer
    {
        public void MoveToLine(ILine line);
        
        public void ExitFromLine(ILine line);

        public bool FindABetterLine(ILine[] lines);

        public bool Swap(ICustomer customer);

    }
}
