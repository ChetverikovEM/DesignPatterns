using UnityEngine;

/*
 * Паттерн: Одиночка (Singleton)
 * Применение: обеспечение существования единственного объекта управления
 * космопортом и глобального доступа к нему.
 * Плюсы: контролируемое создание экземпляра и централизованное управление.
 */

namespace Singleton
{
    public class SpaceportManager : MonoBehaviour
    {
        private static SpaceportManager _instance;
        // Глобальная точка доступа
        public static SpaceportManager Instance => _instance;

        // Проверяем существование экземпляра
        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            _instance = this;
        }

        // Пример метода работы менеджера
        public void LaunchShip(string shipName)
        {
            Debug.Log($"Корабль {shipName} стартовал с космопорта.");
        }
    }
}
