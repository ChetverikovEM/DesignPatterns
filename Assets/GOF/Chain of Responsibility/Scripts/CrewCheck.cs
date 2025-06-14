using UnityEngine;

namespace ChainOfResponsibility
{
    public class CrewCheck : Handler
    {
        // Проверка готовности экипажа
        public override void Handle(string request)
        {
            Debug.Log("Проверка экипажа");
            base.Handle(request);
        }
    }
}
