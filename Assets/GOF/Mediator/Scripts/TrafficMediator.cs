using System.Collections.Generic;
using UnityEngine;

/*
 * Паттерн: Посредник
 * Применение: организация взаимодействия между объектами (кораблями) через
 * центральный объект посредника. Исключает прямые ссылки между участниками.
 * Плюсы: снижает связанность компонентов и упрощает их независимое изменение.
 */

namespace Mediator
{
    public class TrafficMediator : MonoBehaviour
    {
        // Настройка взаимодействия кораблей через посредника
        private void Start()
        {
            TrafficControl control = new TrafficControl();
            var shipA = new GameObject("ShipA").AddComponent<Ship>();
            var shipB = new GameObject("ShipB").AddComponent<Ship>();
            shipA.Init(control);
            shipB.Init(control);
            control.Send("Привет", shipA);
        }
    }
}
