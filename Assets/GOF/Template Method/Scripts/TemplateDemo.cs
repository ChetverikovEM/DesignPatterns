using UnityEngine;

namespace TemplateMethod
{
    public class TemplateDemo : MonoBehaviour
    {
        private void Start()
        {
            var shuttle = GetComponent<ShuttleMaintenance>();
            if (shuttle == null)
            {
                Debug.LogError("ShuttleMaintenance компонент не найден!");
                return;
            }

            shuttle.Execute();
        }
    }
}