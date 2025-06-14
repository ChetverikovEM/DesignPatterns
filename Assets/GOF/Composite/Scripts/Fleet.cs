using System.Collections.Generic;

namespace Composite
{
    public class Fleet : ISpaceUnit
    {
        // Список элементов флота
        private readonly List<ISpaceUnit> _units = new List<ISpaceUnit>();

        // Добавление корабля или подфлота
        public void Add(ISpaceUnit unit)
        {
            _units.Add(unit);
        }

        // Запуск всех единиц во флоте
        public void Launch()
        {
            foreach (var unit in _units)
                unit.Launch();
        }
    }
}
