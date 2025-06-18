using Grasp.Common;
using Grasp.IndirectionPattern;
using UnityEngine;

namespace Grasp.Demo
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField] private DockingBay _dockingBay;
        [SerializeField] private Ship _dockableShip=new Ship("Орион", 85000);

        private void Start()
        {
            DockingService.Dock(_dockableShip, _dockingBay);
        }
    }
}