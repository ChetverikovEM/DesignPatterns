using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class ShipFactory
    {
        // Кеш уже созданных моделей
        private readonly Dictionary<string, ShipModel> _models = new Dictionary<string, ShipModel>();

        // Получение существующей модели или создание новой
        public ShipModel GetModel(string key, Mesh mesh, Material material)
        {
            if (!_models.TryGetValue(key, out var model))
            {
                // Сохраняем новую модель в словарь
                model = new ShipModel { Mesh = mesh, Material = material };
                _models[key] = model;
            }
            return model;
        }
    }
}
