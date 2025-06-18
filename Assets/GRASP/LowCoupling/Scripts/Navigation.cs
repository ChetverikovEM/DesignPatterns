using UnityEngine;

/*
 * Паттерн: Слабая связность
 * Применение: 	минимизация зависимости между объектами. Зависит только от интерфейса `INavigationSystem`. Такой подход упрощает замену
 * или расширение навигационных систем.
 * Плюсы: облегчение тестирования, замена компонентов без изменения клиента.
 */

namespace Grasp.LowCouplingPattern
{
    public interface INavigationSystem
    {
        Vector3 CalculateRoute(Vector3 from, Vector3 to);
    }

    // Null Object для избежания проверок на null
    public class NullNavigationSystem : INavigationSystem
    {
        public Vector3 CalculateRoute(Vector3 from, Vector3 to) => Vector3.zero;
    }

    public class SimpleNavigationSystem : INavigationSystem
    {
        public Vector3 CalculateRoute(Vector3 from, Vector3 to)
        {
            return to - from;
        }
    }

    public class ShipNavigator
    {
        private readonly INavigationSystem _navigationSystem;

        public ShipNavigator(INavigationSystem navigationSystem)
        {
            _navigationSystem = navigationSystem;
        }

        public Vector3 PlotCourse(Vector3 destination)
        {
            return _navigationSystem.CalculateRoute(Vector3.zero, destination);
        }
    }
}
