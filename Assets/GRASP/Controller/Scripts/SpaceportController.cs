using Grasp.Common;
using UnityEngine;

/*
 * Паттерн: Контроллер
 * Применение: принимает входные события и координирует работу других объектов.
 * Он разделяет пользовательский ввод и бизнес‑логику.
 * Плюсы: разделение ответственности, возможность повторного использования логики вне интерфейса.
 * добавление операций (ремонт) к объектам (частям корабля).
 */

namespace Grasp.ControllerPattern
{ 
    // Координирует работу космопорта и выступает в роли Controller
    public class SpaceportController : MonoBehaviour
    {
        [SerializeField] private DockingBay _dockingBay;

        public void DockNewShip(string name, float weight)
        {
            var spaceport = GetComponent<CreatorPattern.Spaceport>();
            var ship = spaceport.BuildShip(name, weight);
            _dockingBay.DockShip(ship);
            var cost = InformationExpertPattern.DockingCostCalculator.Calculate(ship);
            Debug.Log($"Стоимость стыковки: {cost}");
        }
    }
}
