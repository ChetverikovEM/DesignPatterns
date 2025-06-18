using Grasp.Common;
using UnityEngine;

namespace Grasp.PolymorphismPattern
{
    // Демонстрация использования паттерна "Полиморфизм"
    public class DockingDemo : MonoBehaviour
    {
        [SerializeField] private DockingBay _dockingBay;

        private void Start()
        {
            // Создаём шаттл, который реализует IDockable
            IDockable dockableShuttle = new Shuttle("Альфа-1");

            // Используем DockingManager для стыковки, не зная конкретного типа объекта
            DockingManager.Dock(dockableShuttle, _dockingBay);
        }
    }
}
