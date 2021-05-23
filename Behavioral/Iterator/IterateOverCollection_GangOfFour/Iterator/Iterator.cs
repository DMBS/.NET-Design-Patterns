namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        /// <summary>
        /// Gets first item
        /// </summary>
        /// <returns></returns>
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        /// <summary>
        /// Gets next item
        /// </summary>
        /// <returns></returns>
        public Item Next()
        {
            _current += _step;
            if (!IsDone) { return _collection[_current] as Item; }
            else return null;
        }

        /// <summary>
        /// Gets or sets stepsize
        /// </summary>
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        /// <summary>
        /// Gets current iterator item
        /// </summary>
        public Item Current
        {
            get { return _collection[_current] as Item; }
        }

        /// <summary>
        /// Gets whether iteration is complete
        /// </summary>
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
