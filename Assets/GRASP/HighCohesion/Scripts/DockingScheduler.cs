using System.Collections.Generic;
using Grasp.Common;

/*
 * Паттерн: Высокая связность
 * Применение: объекты имеют чётко определённые, логически связанные обязанности. Управляет исключительно расписанием.
 * В классе отсутствует лишняя логика, благодаря чему код проще поддерживать.
 * Плюсы: повышенная читаемость и переиспользуемость, меньше побочных эффектов.
 */

namespace Grasp.HighCohesionPattern
{
    // Класс отвечает только за расписание стыковок, обеспечивая высокую связность
    public class DockingScheduler
    {
        private readonly List<Ship> _scheduledShips = new();

        public void AddShip(Ship ship)
        {
            _scheduledShips.Add(ship);
        }

        public IReadOnlyList<Ship> GetSchedule() => _scheduledShips;
    }
}
