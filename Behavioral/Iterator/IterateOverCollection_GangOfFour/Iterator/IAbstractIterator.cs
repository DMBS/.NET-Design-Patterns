namespace Iterator
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item Current { get; }
    }
}
