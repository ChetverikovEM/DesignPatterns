using UnityEngine;

namespace Grasp.Common
{
    // Доковый отсек космопорта
    public class DockingBay : MonoBehaviour
    {
        [SerializeField] private int _bayNumber;

        public int BayNumber => _bayNumber;

        public void DockShip(Ship ship)
        {
            Debug.Log($"Корабль {ship.Name} пристыкован к доку {_bayNumber}");
        }
    }
}
