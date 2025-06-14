using UnityEngine;

namespace ChainOfResponsibility
{
    public class FuelCheck : Handler
    {
        // Проверка наличия топлива
        public override void Handle(string request)
        {
            Debug.Log("Проверка топлива");
            base.Handle(request);
        }
    }
}
