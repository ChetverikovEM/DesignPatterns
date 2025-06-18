using UnityEngine;

namespace Grasp.LowCouplingPattern
{

    public class DemoNavigator : MonoBehaviour
    {
        private void Start()
        {
            INavigationSystem navigation = new SimpleNavigationSystem();
            ShipNavigator navigator = new ShipNavigator(navigation);

            Vector3 destination = new Vector3(100, 0, 50);
            Vector3 direction = navigator.PlotCourse(destination);

            Debug.Log($"[DemoNavigator] Корабль полетит в направлении: {direction}");
        }
    }
}