using UnityEngine;

namespace TemplateMethod
{
    public abstract class MaintenanceProcedure : MonoBehaviour
    {
        // Общий алгоритм обслуживания
        public void Execute()
        {
            CheckSystems();
            Service();
            Report();
        }

        // Проверка систем корабля
        protected abstract void CheckSystems();
        // Ремонтные действия
        protected abstract void Service();
        // Отчет по результатам обслуживания
        protected virtual void Report()
        {
            Debug.Log("Обслуживание завершено");
        }
    }
}
