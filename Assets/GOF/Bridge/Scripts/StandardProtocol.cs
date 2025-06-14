using UnityEngine;

namespace Bridge
{
    public class StandardProtocol : IDockingProtocol
    {
        // Стыковка по базовому протоколу
        public void Dock(string shipName)
        {
            Debug.Log($"Корабль {shipName} стыкуется по стандартному протоколу");
        }
    }
}
