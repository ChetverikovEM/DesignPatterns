using UnityEngine;

/*
 * Паттерн: Шаблонный метод
 * Применение: определяет общую последовательность обслуживания корабля, а
 * детали проверок и ремонта перекладывает на подклассы.
 * Плюсы: переиспользование алгоритма и возможность изменять отдельные шаги.
 */

namespace TemplateMethod
{
    public class ShuttleMaintenance : MaintenanceProcedure
    {
        // Специфическая проверка систем шаттла
        protected override void CheckSystems()
        {
            Debug.Log("Проверка систем шаттла");
        }

        // Конкретные ремонтные действия для шаттла
        protected override void Service()
        {
            Debug.Log("Замена изношенных деталей");
        }
    }
}
