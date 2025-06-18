using UnityEngine;

namespace Grasp.ControllerPattern
{
    public class ControllerDemo : MonoBehaviour
    {
        [SerializeField] private SpaceportController _spaceportController=new ();
        [SerializeField] private string _spaceShipName="Орион25";
        [SerializeField] private float _spaceShipWeight = 25748;
        
        private void Start()
        {
            _spaceportController.DockNewShip(_spaceShipName, _spaceShipWeight);
        }
    }
}