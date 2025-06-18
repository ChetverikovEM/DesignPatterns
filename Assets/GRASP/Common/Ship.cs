using UnityEngine;

namespace Grasp.Common
{
    // Простая модель корабля космопорта
    public class Ship : IDockable
    {
        public string Name { get; }
        public float Weight { get; }

        public Ship(string name, float weight = 0f)
        {
            Name = name;
            Weight = weight;
        }

        public void Dock(DockingBay bay)
        {
            bay.DockShip(this);
        }
    }
}
