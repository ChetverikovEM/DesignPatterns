using UnityEngine;

namespace Observer
{
    public class ControlTower : MonoBehaviour
    {
        // Делегат и событие прибытия корабля
        public delegate void ShipEvent(string name);
        public event ShipEvent OnShipArrived;

        // Уведомляем подписчиков о прибытии
        public void NotifyArrival(string shipName)
        {
            OnShipArrived?.Invoke(shipName);
        }
    }
}
