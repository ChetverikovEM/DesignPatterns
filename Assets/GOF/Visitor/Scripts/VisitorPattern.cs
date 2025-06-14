using UnityEngine;

/*
 * Паттерн: Посетитель
 * Применение: добавление операций (ремонт) к объектам (частям корабля)
 * без изменения их классов. Посетитель обходит элементы и выполняет действия.
 * Плюсы: разделение структур данных и операций над ними, возможность добавлять
 * новые операции без модификации элементов.
 */

namespace Visitor
{
    public class VisitorDemo : MonoBehaviour
    {
        // Создаем элемент и посетителя, затем запускаем обход
        private void Start()
        {
            var part = new GameObject("Engine").AddComponent<EnginePart>();
            var visitor = new RepairVisitor();
            part.Accept(visitor);
        }
    }
}
