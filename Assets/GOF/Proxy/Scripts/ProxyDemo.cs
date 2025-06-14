using UnityEngine;

namespace Proxy
{
    public class ProxyDemo : MonoBehaviour
    {
        [SerializeField] private string _shipName = "Коготь Орла";
        [SerializeField] private bool _grantAccess;

        private void Start()
        {
            IDockingBay docking = new SecurityProxy(_grantAccess);
            docking.Dock(_shipName);
        }
    }
}