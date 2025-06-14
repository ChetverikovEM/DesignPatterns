using UnityEngine;

/*
 * Паттерн: Декоратор
 * Абстрактный класс, позволяющий оборачивать объекты оружия и расширять
 * их поведение без изменения исходного класса.
 */

namespace Decorator
{
    public abstract class WeaponDecorator : IWeapon
    {
        // Ссылка на декорируемый объект
        protected readonly IWeapon weapon;

        // Запоминаем базовое оружие
        protected WeaponDecorator(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        // Выполнение базовой атаки
        public virtual void Attack()
        {
            weapon.Attack();
        }
    }
}
