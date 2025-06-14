using UnityEngine;

namespace Singleton
{
    public class SingletonDemo : MonoBehaviour
    {
        [SerializeField] private string _shipName = "Первооткрыватель";

        private void Start()
        {
            if (SpaceportManager.Instance == null)
            {
                Debug.LogError("SpaceportManager ещё не создан в сцене!");
                return;
            }

            SpaceportManager.Instance.LaunchShip(_shipName);
        }
    }
}