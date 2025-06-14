using UnityEngine;

namespace AbstractFactory
{
    public class WarpEngine : IEngine
    {
        // Запуск варп‑двигателя
        public void StartEngine()
        {
            Debug.Log("Варп-двигатель запущен");
        }
    }
}
