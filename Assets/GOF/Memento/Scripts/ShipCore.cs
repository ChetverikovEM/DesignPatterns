using UnityEngine;

namespace Memento
{
    public class Ship : MonoBehaviour
    {
        // Сохраняем текущее состояние
        public ShipState Save()
        {
            return new ShipState { Position = transform.position };
        }

        // Восстанавливаем сохраненное состояние
        public void Restore(ShipState state)
        {
            transform.position = state.Position;
        }
    }
}
