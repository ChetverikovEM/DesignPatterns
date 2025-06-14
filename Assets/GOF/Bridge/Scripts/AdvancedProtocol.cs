using UnityEngine;

namespace Bridge
{
    public class AdvancedProtocol : IDockingProtocol
    {
        // Стыковка по расширенному протоколу
        public void Dock(string shipName)
        {
            Debug.Log($"Корабль {shipName} стыкуется по продвинутому протоколу");
        }
    }
}
