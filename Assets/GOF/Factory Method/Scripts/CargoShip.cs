using UnityEngine;

namespace FactoryMethod
{
    public class CargoShip : IShip
    {
        // Реализация запуска грузового корабля
        public void Launch()
        {
            Debug.Log("Грузовой корабль запускается");
        }
    }
}
