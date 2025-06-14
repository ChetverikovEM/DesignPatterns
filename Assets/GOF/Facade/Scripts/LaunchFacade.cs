using UnityEngine;

/*
 * Паттерн: Фасад
 * Применение: предоставляет упрощенный интерфейс для сложной подсистемы
 * запуска корабля, объединяя работу двигателей и навигации в одном классе.
 * Плюсы: сокращает зависимость клиентского кода от деталей подсистем,
 * делает интерфейс более понятным.
 */

namespace Facade
{
    public class LaunchFacade : MonoBehaviour
    {
        private readonly Engine _engine = new Engine();
        private readonly Navigation _navigation = new Navigation();

        [SerializeField] private string _destination = "Луна";

        private void Start()
        {
            Launch();
        }

        [ContextMenu("Запуск")]
        // Запуск корабля через фасад
        public void Launch()
        {
            _engine.StartEngine();
            _navigation.SetCourse(_destination);
            Debug.Log("Корабль стартовал!");
        }
    }
}
