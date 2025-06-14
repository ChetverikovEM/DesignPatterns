using System.Collections.Generic;
using UnityEngine;

/*
 * Паттерн: Компоновщик
 * Применение: позволяет работать с группой объектов (флот) как с единым
 * целым, выстраивая древовидную структуру элементов. Корабли и флоты
 * реализуют общий интерфейс.
 * Плюсы: упрощает работу с иерархиями объектов и клиентский код не зависит
 * от количества уровней в структуре.
 */

namespace Composite
{
    public class FleetComposite : MonoBehaviour
    {
        // Пример формирования и запуска флота
        private void Start()
        {
            Fleet fleet = new Fleet();
            fleet.Add(new Ship("Alpha"));
            fleet.Add(new Ship("Beta"));
            fleet.Launch();
        }
    }
}
