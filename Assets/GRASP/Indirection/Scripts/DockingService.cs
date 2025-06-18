using Grasp.Common;
using Grasp.PureFabricationPattern;

/*
 * Паттерн: Посредник
 * Применение: введение объекта-посредника для уменьшения зависимости. Выступает промежуточным слоем между доком
 * и объектом стыковки. Через него можно легко добавлять дополнительную обработку.
 * Плюсы: уменьшение связности, гибкость при изменениях процессов.
 */

namespace Grasp.IndirectionPattern
{
    // Прослойка между доком и объектом стыковки
    public static class DockingService
    {
        public static void Dock(IDockable ship, DockingBay bay)
        {
            ship.Dock(bay);
            EventLogger.Log($"{ship.GetType().Name} стыковался через службу");
        }
    }
}
