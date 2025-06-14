using UnityEngine;

/*
 * Паттерн: Цепочка обязанностей
 * Применение: последовательная обработка запроса (подготовка к запуску)
 * несколькими объектами. Каждый обработчик решает, передавать ли запрос далее.
 * Плюсы: уменьшает зависимость между отправителем и получателями запроса,
 * упрощает добавление новых этапов обработки.
 */

namespace ChainOfResponsibility
{
    public class LaunchChain : MonoBehaviour
    {
        // Формирование цепочки проверок и запуск
        private void Start()
        {
            var fuel = gameObject.AddComponent<FuelCheck>();
            var crew = gameObject.AddComponent<CrewCheck>();
            fuel.SetNext(crew);

            fuel.Handle("start");
        }
    }
}
