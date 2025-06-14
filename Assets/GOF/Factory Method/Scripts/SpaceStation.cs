using UnityEngine;

/*
 * Паттерн: Фабричный метод (Factory Method)
 * Применение: позволяет делегировать создание объектов (разных типов кораблей)
 * подклассам (разные станции) через общий интерфейс базового класса.
 * Плюсы: изолирует создание объектов, соблюдает SRP и OCP,
 * облегчает добавление новых типов кораблей без изменения логики запуска.
 */

namespace FactoryMethod
{
    public abstract class SpaceStation : MonoBehaviour
    {
        // Фабричный метод создания корабля
        protected abstract IShip CreateShip();

        [ContextMenu("Запуск")]
        // Общая логика запуска независимо от типа корабля
        public void LaunchShip()
        {
            var ship = CreateShip();
            ship.Launch();
        }
    }
}
