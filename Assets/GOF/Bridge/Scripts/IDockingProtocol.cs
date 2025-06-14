using UnityEngine;

namespace Bridge
{
    public interface IDockingProtocol
    {
        // Процедура стыковки корабля
        void Dock(string shipName);
    }
}
