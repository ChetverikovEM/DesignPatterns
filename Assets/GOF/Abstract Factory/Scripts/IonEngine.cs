using UnityEngine;

namespace AbstractFactory
{
    public class IonEngine : IEngine
    {
        // Запуск ионного двигателя
        public void StartEngine()
        {
            Debug.Log("Ионный двигатель запущен");
        }
    }
}
