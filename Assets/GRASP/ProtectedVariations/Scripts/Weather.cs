using UnityEngine;

/*
 * Паттерн: Защищённые изменения
 * Применение: интерфейсы и абстракции защищают от изменений в зависимых классах. Обращается к абстракции `IWeatherService`. Изменение способа получения данных
 * о погоде не затронет работу координатора.
 * Плюсы: защита от изменений внешних сервисов, возможность подмены реализации.
 */

namespace Grasp.ProtectedVariationsPattern
{
    public interface IWeatherService
    {
        bool IsSafeToLand();
    }

    public class RandomWeatherService : IWeatherService
    {
        public bool IsSafeToLand() => Random.value > 0.3f;
    }

    public class LandingCoordinator
    {
        private readonly IWeatherService _weatherService;

        public LandingCoordinator(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public bool CanLand()
        {
            return _weatherService.IsSafeToLand();
        }
    }
}
