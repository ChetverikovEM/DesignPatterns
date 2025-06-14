using UnityEngine;

namespace Composite
{
    public class Ship : ISpaceUnit
    {
        // Имя конкретного корабля
        private readonly string _name;

        // Инициализация корабля
        public Ship(string name)
        {
            _name = name;
        }

        // Запуск отдельного корабля
        public void Launch()
        {
            Debug.Log($"Корабль {_name} вылетел.");
        }
    }
}
