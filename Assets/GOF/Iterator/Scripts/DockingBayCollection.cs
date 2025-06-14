using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class DockingBayCollection : IEnumerable<string>
    {
        // Список доступных посадочных мест
        private readonly List<string> _bays = new List<string> { "A1", "B2", "C3" };

        public IEnumerator<string> GetEnumerator() => _bays.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
