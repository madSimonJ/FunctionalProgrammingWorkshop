using System.Collections;

namespace FunctionalCSharpWorkshop
{
    public class IndefiniteEnumerable<T> : IEnumerable<T>
    {
        private readonly T _firstValue;
        private readonly Func<T, bool> _predicate;
        private readonly Func<T, T> _iteration;

        public IndefiniteEnumerable(T firstValue, Func<T, bool> predicate, Func<T, T> iteration)
        {
            _firstValue = firstValue;
            _predicate = predicate;
            _iteration = iteration;
        }

        IEnumerator<T> MakeEnumerator()
        {
            return new IndefiniteEnumerator<T>(_firstValue, _predicate, _iteration);
        }

        public IEnumerator<T> GetEnumerator() =>
            MakeEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            MakeEnumerator();
    }

    public class IndefiniteEnumerator<T> : IEnumerator<T>
    {
        public IndefiniteEnumerator(T firstValue, Func<T, bool> predicate, Func<T, T> iteration)
        {
            _current = firstValue;
            _firstValue = firstValue;
            _predicate = predicate;
            _iteration = iteration;
        }

        public T Current => _current;
        private T _current;
        private readonly T _firstValue;
        private readonly Func<T, bool> _predicate;
        private readonly Func<T, T> _iteration;
        
        private bool isFirstIteration = true;
        private bool isPenultimateIteration = false;
        
        object IEnumerator.Current => _current;

        public void Dispose()
        {
            if(_current is IDisposable disposable)
                disposable.Dispose();
        }

        public bool MoveNext()
        {
            if(isFirstIteration)
            {
                isFirstIteration = false;
                return true;
            }
            if(isPenultimateIteration)
            {
                isPenultimateIteration = false;
                return false;
            }

            _current = _iteration(Current);
            isPenultimateIteration = !_predicate(_current);
            
            return true;
        }

        public void Reset()
        {
            _current = _firstValue;
        }
    }
}
