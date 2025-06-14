using UnityEngine;

/*
 * Паттерн: Адаптер
 * Применение: позволяет использовать устаревшие или несовместимые классы
 * (старую систему заправки) через общий интерфейс новой системы.
 * Плюсы: обеспечивает совместимость интерфейсов без изменения существующего кода
 * и способствует повторному использованию.
 */

namespace Adapter
{
    public class FuelAdapter : MonoBehaviour, INewFuelSystem
    {
        [SerializeField] private LegacyFuelSystem _legacySystem;

        private void Start()
        {
            Debug.Log("Новый интерфейс просит заправку...");
            Refuel();
        }
        
        // Адаптация вызова к устаревшему методу
        public void Refuel()
        {
            if (_legacySystem == null)
            {
                Debug.LogError("LegacyFuelSystem не назначена в инспекторе!");
                return;
            }

            _legacySystem.OldRefuel();
        }
    }
}
