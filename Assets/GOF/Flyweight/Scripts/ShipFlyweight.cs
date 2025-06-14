using System.Collections.Generic;
using UnityEngine;

/*
 * Паттерн: Приспособленец (Flyweight)
 * Применение: экономия памяти за счет разделения общих данных между
 * объектами (модели кораблей). Хранит и переиспользует уже созданные
 * экземпляры моделей.
 * Плюсы: снижает потребление ресурсов при большом количестве однотипных
 * объектов.
 */

namespace Flyweight
{
    public class ShipFlyweight : MonoBehaviour
    {
        [SerializeField] private Mesh _mesh;
        [SerializeField] private Material _material;
        private ShipFactory _factory = new ShipFactory();

        // Запрашиваем модель и выводим информацию
        private void Start()
        {
            ShipModel model = _factory.GetModel("basic", _mesh, _material);
            Debug.Log($"Использована модель {model.Mesh.name}");
        }
    }
}
