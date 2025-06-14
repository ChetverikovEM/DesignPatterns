using UnityEngine;

/*
 * Паттерн: Прототип
 * Применение: создание новых объектов кораблей путем клонирования
 * заранее подготовленного префаба. Удобно при множественном создании
 * однотипных объектов.
 * Плюсы: экономия ресурсов на создание и настройку новых экземпляров.
 */

namespace Prototype
{
    public class ShipPrototype : MonoBehaviour
    {
        [SerializeField] private GameObject _shipPrefab;

        // Клонирование корабля в указанной позиции
        public GameObject Clone(Vector3 position)
        {
            return Instantiate(_shipPrefab, position, Quaternion.identity);
        }

        // Пример создания клона при запуске
        private void Start()
        {
            if (_shipPrefab != null)
            {
                Clone(new Vector3(0, 0, 0));
            }
        }
    }
}
