using UnityEngine;

/*
 * Паттерн: Хранитель (Memento)
 * Применение: сохранение и восстановление состояния объекта корабля без
 * нарушения инкапсуляции. Полезно при реализации отката действий.
 * Плюсы: позволяет реализовать историю изменений, не раскрывая внутренние
 * данные объекта.
 */

namespace Memento
{
    public class ShipMemento : MonoBehaviour
    {
        [SerializeField] private Ship _ship;
        private ShipState _saved;

        [ContextMenu("Сохранить")]
        // Сохранение состояния через хранитель
        public void Save()
        {
            _saved = _ship.Save();
            Debug.Log("Состояние сохранено");
        }

        [ContextMenu("Восстановить")]
        // Восстановление состояния
        public void Restore()
        {
            if (_saved == null)
            {
                Debug.LogError("Нет сохранённых состояний корабля!");
                return;
            }

            _ship.Restore(_saved);
            Debug.Log("Состояние восстановлено");

        }
    }
}
