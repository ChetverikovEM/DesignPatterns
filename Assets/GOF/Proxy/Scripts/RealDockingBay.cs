using UnityEngine;

namespace Proxy
{
    public class RealDockingBay : IDockingBay
    {
        // Реальная работа по стыковке
        public void Dock(string shipName)
        {
            Debug.Log($"Корабль {shipName} пришвартован");
        }
    }
}
