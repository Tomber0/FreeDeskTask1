namespace FreeDeskTask1.Model
{
    interface ICustomer
    {
        public void MoveToLine(ILine line);
        
        public void ExitFromLine();

        public bool FindABetterLine(ILine[] lines);

        public bool Swap(ICustomer customer);

    }
}
