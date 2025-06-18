using UnityEngine;

namespace Grasp.PureFabricationPattern
{
    // Демонстрирует использование искусственного объекта для логирования
    public class EventLoggerDemo : MonoBehaviour
    {
        private void Start()
        {
            EventLogger.Log("Корабль 'Пегас' прибыл на орбиту.");
            EventLogger.Log("Выполняется проверка систем...");
            EventLogger.Log("Стыковка с доком №3 завершена.");
        }
    }
}