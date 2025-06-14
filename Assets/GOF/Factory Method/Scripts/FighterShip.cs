using UnityEngine;

namespace FactoryMethod
{
    public class FighterShip : IShip
    {
        // Запуск истребителя
        public void Launch()
        {
            Debug.Log("Истребитель запускается");
        }
    }
}
