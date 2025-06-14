using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Паттерн: Итератор
 * Применение: последовательный обход коллекции стыковочных мест без раскрытия
 * внутренней структуры. Реализует общий интерфейс IEnumerable.
 * Плюсы: упрощает работу с различными коллекциями и поддерживает единый способ
 * обхода элементов.
 */

namespace Iterator
{
    public class BayIterator : MonoBehaviour
    {
        // Перебираем коллекцию и выводим информацию
        private void Start()
        {
            var collection = new DockingBayCollection();
            foreach (var bay in collection)
            {
                Debug.Log($"Бай {bay} готов");
            }
        }
    }
}
