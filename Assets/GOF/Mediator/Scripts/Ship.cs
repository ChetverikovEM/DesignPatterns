using UnityEngine;

namespace Mediator
{
    public class Ship : MonoBehaviour, IShip
    {
        private TrafficControl _control;
        [SerializeField] private string _name;

        // Регистрируемся у диспетчера
        public void Init(TrafficControl control)
        {
            _control = control;
            control.Register(this);
        }

        // Обработка полученного сообщения
        public void Receive(string message)
        {
            Debug.Log($"{_name} получил сообщение: {message}");
        }
    }
}
