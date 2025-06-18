using Grasp.Common;
using UnityEngine;

namespace Grasp.PolymorphismPattern
{
    // Другой тип корабля со своей логикой стыковки
    public class Shuttle : IDockable
    {
        public string Identifier { get; }

        public Shuttle(string identifier)
        {
            Identifier = identifier;
        }

        public void Dock(DockingBay bay)
        {
            bay.DockShip(new Ship(Identifier));
            Debug.Log($"Шаттл {Identifier} пристыкован через адаптер");
        }
    }
}
