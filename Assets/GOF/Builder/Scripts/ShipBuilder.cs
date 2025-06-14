using UnityEngine;

/*
 * Паттерн: Строитель
 * Применение: поэтапное создание сложных объектов (космического корабля) с
 * различными конфигурациями. Позволяет разделить процесс конструирования и
 * представление объекта.
 * Плюсы: гибкое создание различных вариантов продукта, код клиента становится
 * чище и понятнее.
 */

namespace Builder
{
    public class BuilderDemo : MonoBehaviour
    {
        // Пример использования строителя
        private void Start()
        {
            SpaceShip ship = new ShipBuilder()
                .SetName("Falcon")
                .AddWeapons()
                .AddShields()
                .Build();

            Debug.Log($"Построен корабль {ship.Name}.");
        }
    }
}
