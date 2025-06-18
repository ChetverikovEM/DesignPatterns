using Grasp.Common;
using UnityEngine;

/*
 * Паттерн: Создатель
 * Применение: отвечает за создание экземпляров других классов. В данном примере отвечает за создание экземпляров `Ship`.
 * Такой подход концентрирует логику инициализации в одном месте, упрощая поддержку и расширение.
 * Плюсы: соблюдение SRP, инкапсуляция процесса создания, упрощение тестирования.
 */

namespace Grasp.CreatorPattern
{
    // Spaceport выступает в роли Creator и управляет созданием кораблей
    public class Spaceport : MonoBehaviour
    {
        public Ship BuildShip(string name, float weight)
        {
            return new Ship(name, weight);
        }
    }
}
