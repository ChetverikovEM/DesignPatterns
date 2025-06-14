using UnityEngine;

/*
 * Паттерн: Стратегия
 * Применение: выбор алгоритма посадки корабля (мягкая или быстрая) во время
 * выполнения. Стратегии реализуют общий интерфейс.
 * Плюсы: позволяет легко добавлять новые алгоритмы и переключаться между ними
 * без изменения контекста.
 */

namespace Strategy
{
    public class LandingContext : MonoBehaviour
    {
        [SerializeField] private string _shipName = "Бедуин";
        private ILandingStrategy _strategy;

        // По умолчанию выбираем мягкую посадку
        private void Awake()
        {
            _strategy = new SoftLanding(); // или FastLanding()
        }
        
        [ContextMenu("Посадка")]
        // Выполнить посадку через выбранную стратегию
        public void Land()
        {
            _strategy.Land(_shipName);
        }
    }
}
