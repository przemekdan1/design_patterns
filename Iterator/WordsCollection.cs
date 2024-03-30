using System;
using System.Collections;

namespace Iterator
{
    class WordsCollection : IteratorAgregate
    {
        List<string> _collection = new List<string>();
        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> GetItems()
        {
            return _collection;
        }
        public void AddItem(string item)
        {
            this._collection.Add(item);
        }
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this,_direction);
        }
    }
}