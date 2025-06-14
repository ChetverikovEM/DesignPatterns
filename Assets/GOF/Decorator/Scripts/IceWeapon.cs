using UnityEngine;

/*
 * Паттерн: Декоратор
 * Конкретный декоратор, добавляющий ледяной урон к базовому оружию.
 */

namespace Decorator
{
    public class IceWeapon : WeaponDecorator
    {
        // Передаем базовое оружие в конструктор
        public IceWeapon(IWeapon weapon) : base(weapon) { }

        // Дополняем атаку ледяным уроном
        public override void Attack()
        {
            base.Attack();
            Debug.Log("Добавлен ледяной урон");
        }
    }
}
