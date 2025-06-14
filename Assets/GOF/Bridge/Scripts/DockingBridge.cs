using UnityEngine;

/*
 * Паттерн: Мост
 * Применение: разделяет абстракцию (мост стыковки) и реализацию протокола,
 * позволяя изменять их независимо. Подходит, когда необходимо поддерживать
 * несколько вариантов реализации без взрывного роста подклассов.
 * Плюсы: упрощает расширение и модификацию кода, снижает связность между
 * абстракцией и реализацией.
 */

namespace Bridge
{
    public class DockingBridge : MonoBehaviour
    {
        [SerializeField] private string _shipName = "Orion";
        [SerializeField] private bool _useAdvanced;
        private IDockingProtocol _protocol;

        private void Awake()
        {
            // В зависимости от настройки выбираем реализацию протокола
            _protocol = _useAdvanced ? new AdvancedProtocol() as IDockingProtocol : new StandardProtocol();
        }

        private void Start()
        {
            // Выполняем стыковку
            _protocol.Dock(_shipName);
        }
    }
}
