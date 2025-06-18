using Grasp.Common;

/*
 * Паттерн: Полиморфизм
 * Применение: использование наследования/интерфейсов для делегирования поведения. Взаимодействует с объектами через
 * интерфейс `IDockable`. Конкретные типы кораблей реализуют собственные способы стыковки.
 * Плюсы: расширяемость без изменения существующего кода, соблюдение OCP.
 */

namespace Grasp.PolymorphismPattern
{
    // Осуществляет стыковку объектов, опираясь на полиморфизм IDockable
    public static class DockingManager
    {
        public static void Dock(IDockable dockable, DockingBay bay)
        {
            dockable.Dock(bay);
        }
    }
}
