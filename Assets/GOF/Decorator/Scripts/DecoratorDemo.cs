using UnityEngine;

/*
 * Паттерн: Декоратор
 * Демонстрация последовательного добавления эффектов к оружию
 * с помощью цепочки декораторов.
 */

namespace Decorator
{
    public class DecoratorDemo : MonoBehaviour
    {
        // Создание базового оружия и последовательное добавление эффектов
        private void Start()
        {
            IWeapon weapon = new BasicWeapon();
            // Добавляем огненный эффект
            weapon = new FireWeapon(weapon);
            // Затем ледяной эффект
            weapon = new IceWeapon(weapon);
            weapon.Attack();
        }
    }
}
