using UnityEngine;

namespace Command
{
    public class LaunchCommand : ICommand
    {
        // Имя корабля, для которого выполняется команда
        private readonly string _shipName;

        // Сохраняем параметры команды
        public LaunchCommand(string shipName)
        {
            _shipName = shipName;
        }

        // Реализация запуска корабля
        public void Execute()
        {
            Debug.Log($"Корабль {_shipName} запускается");
        }
    }
}
