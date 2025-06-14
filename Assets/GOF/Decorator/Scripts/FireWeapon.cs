using UnityEngine;

/*
 * Паттерн: Декоратор
 * Конкретный декоратор, добавляющий огненный урон к базовому оружию.
 */

namespace Decorator
{
    public class FireWeapon : WeaponDecorator
    {
        // Передаем базовое оружие в конструктор
        public FireWeapon(IWeapon weapon) : base(weapon) { }

        // Дополняем атаку огненным уроном
        public override void Attack()
        {
            base.Attack();
            Debug.Log("Добавлен огненный урон");
        }
    }
}
