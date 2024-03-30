using System;
using System.Collections;

namespace Iterator
{
    abstract class IteratorAgregate
    {
        public abstract IEnumerator GetEnumerator();
    }
}