using UnityEngine;

/*
 * Паттерн: Декоратор
 * Данный класс представляет базовую реализацию оружия, к которой могут
 * динамически добавляться новые эффекты через декораторы.
 */

namespace Decorator
{
    public class BasicWeapon : IWeapon
    {
        // Базовая атака без дополнительных эффектов
        public void Attack()
        {
            Debug.Log("Базовая атака");
        }
    }
}
