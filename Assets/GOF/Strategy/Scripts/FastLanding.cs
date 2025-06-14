using UnityEngine;

namespace Strategy
{
    public class FastLanding : ILandingStrategy
    {
        // Быстрая посадка
        public void Land(string shipName)
        {
            Debug.Log($"{shipName} совершает быструю посадку");
        }
    }
}
