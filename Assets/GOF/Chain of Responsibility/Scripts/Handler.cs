using UnityEngine;

namespace ChainOfResponsibility
{
    public abstract class Handler : MonoBehaviour
    {
        [SerializeField] private Handler _next;

        // Установить следующий обработчик в цепочке
        public void SetNext(Handler next) => _next = next;

        // Базовая реализация обработки
        public virtual void Handle(string request)
        {
            _next?.Handle(request);
        }
    }
}
