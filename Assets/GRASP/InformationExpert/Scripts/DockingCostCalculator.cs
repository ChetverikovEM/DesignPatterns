using Grasp.Common;
using UnityEngine;

/*
 * Паттерн: Информационный эксперт
 * Применение: объект, обладающий нужными данными, реализует поведение. Получает данные непосредственно от `Ship`,
 * который содержит всю нужную информацию о себе. Расчёт стоимости сосредоточен рядом с источником данных.
 * Плюсы: низкая связанность между классами, защита инкапсуляции данных.
 */

namespace Grasp.InformationExpertPattern
{
    // Рассчитывает стоимость стыковки исходя из веса корабля
    public static class DockingCostCalculator
    {
        public static float Calculate(Ship ship)
        {
            // Ship имеет всю информацию о своём весе, поэтому выступает в роли Information Expert
            return ship.Weight * 10f;
        }
    }
}
