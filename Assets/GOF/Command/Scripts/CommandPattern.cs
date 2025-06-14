using UnityEngine;

/*
 * Паттерн: Команда
 * Применение: инкапсуляция запросов на выполнение действий (запуск корабля)
 * в отдельные объекты. Позволяет откладывать, логировать и комбинировать команды.
 * Плюсы: разделение отправителя и получателя, возможность создавать очереди
 * и макросы команд.
 */

namespace Command
{
    public class CommandInvoker : MonoBehaviour
    {
        private ICommand _command;

        // Инициализация и выполнение команды
        private void Start()
        {
            _command = new LaunchCommand("Vega");
            _command.Execute();
        }
    }
}
