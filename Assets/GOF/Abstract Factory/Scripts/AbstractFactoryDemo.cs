using UnityEngine;

/*
 * Паттерн: Абстрактная фабрика
 * Применение: создание семейств связанных объектов (двигателей кораблей) без
 * указания их конкретных классов. Позволяет легко расширять линейку
 * производимых объектов.
 * Плюсы: изолирует код клиента от конкретных реализаций, облегчает замену
 * целых семейств продуктов и поддерживает принцип открытости/закрытости.
 */

namespace AbstractFactory
{
    public class AbstractFactoryDemo : MonoBehaviour
    {
        // Демонстрация работы паттерна
        private void Start()
        {
            // Создание и запуск двигателя грузового корабля
            IShipFactory cargoFactory = new CargoShipFactory();
            IEngine cargoEngine = cargoFactory.CreateEngine();
            cargoEngine.StartEngine();

            // Создание и запуск двигателя боевого корабля
            IShipFactory battleFactory = new BattleShipFactory();
            IEngine battleEngine = battleFactory.CreateEngine();
            battleEngine.StartEngine();
        }
    }
}
