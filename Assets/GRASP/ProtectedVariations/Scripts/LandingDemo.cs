using UnityEngine;

namespace Grasp.ProtectedVariationsPattern
{
    // Демонстрация защищённого обращения к погодной системе
    public class LandingDemo : MonoBehaviour
    {
        private void Start()
        {
            // Внедряем зависимость через интерфейс
            IWeatherService weatherService = new RandomWeatherService();
            var coordinator = new LandingCoordinator(weatherService);

            // Проверяем можно ли совершить посадку
            if (coordinator.CanLand())
                Debug.Log("Посадка разрешена: погодные условия благоприятны.");
            else
                Debug.Log("Посадка запрещена: неблагоприятные погодные условия.");
        }
    }
}