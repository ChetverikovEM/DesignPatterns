using UnityEngine;

/*
 * Паттерн: Наблюдатель
 * Применение: оповещение множества объектов (кораблей) о событии от
 * одного источника (диспетчерская башня). Позволяет динамически подписываться
 * и отписываться от уведомлений.
 * Плюсы: слабая связанность между отправителем и получателями событий.
 */

namespace Observer
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private ControlTower _tower;
        [SerializeField] private string _name;

        private void Start()
        {
            _tower.OnShipArrived += ShipArrived;
            _tower.NotifyArrival(_name);
        }

        // Реакция на уведомление диспетчера
        private void ShipArrived(string shipName)
        {
            Debug.Log($"{shipName} прибыл к космопорту");
        }
    }
}
