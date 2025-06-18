using Grasp.Common;
using UnityEngine;

namespace Grasp.HighCohesionPattern
{
    public class SchedulerDemo : MonoBehaviour
    {
        private void Start()
        {
            var scheduler = new DockingScheduler();

            var ship1 = new Ship("Гагарин", 800f);
            var ship2 = new Ship("Тайконафт", 950f);

            scheduler.AddShip(ship1);
            scheduler.AddShip(ship2);

            Debug.Log("Текущее расписание стыковок:");

            foreach (var ship in scheduler.GetSchedule())
            {
                Debug.Log($" - {ship.Name}, масса: {ship.Weight} кг");
            }
        }
    }
}