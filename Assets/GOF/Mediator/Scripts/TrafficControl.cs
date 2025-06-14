using System.Collections.Generic;

namespace Mediator
{
    public class TrafficControl
    {
        // Зарегистрированные корабли
        private readonly List<IShip> _ships = new List<IShip>();

        // Добавляем корабль под управление
        public void Register(IShip ship)
        {
            _ships.Add(ship);
        }

        // Отправка сообщения всем, кроме отправителя
        public void Send(string message, IShip sender)
        {
            foreach (var ship in _ships)
            {
                if (ship != sender)
                    ship.Receive(message);
            }
        }
    }
}
