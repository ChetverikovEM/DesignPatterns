using UnityEngine;

namespace Facade
{
    public class Navigation
    {
        // Установка курса полета
        public void SetCourse(string destination) => Debug.Log($"Курс на {destination} установлен");
    }
}
