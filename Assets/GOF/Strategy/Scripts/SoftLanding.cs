using UnityEngine;

namespace Strategy
{
    public class SoftLanding : ILandingStrategy
    {
        // Мягкая посадка
        public void Land(string shipName)
        {
            Debug.Log($"{shipName} совершает мягкую посадку");
        }
    }
}
