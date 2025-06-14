using UnityEngine;

/*
 * Паттерн: Заместитель (Proxy)
 * Применение: контроль доступа к реальному объекту причала через прокси,
 * который проверяет авторизацию.
 * Плюсы: позволяет добавлять дополнительную логику (например, безопасность)
 * без изменения реального объекта.
 */

namespace Proxy
{
    public class SecurityProxy : IDockingBay
    {
        private readonly IDockingBay _realBay;
        private readonly bool _authorized;

        public SecurityProxy(bool authorized)
        {
            _realBay = new RealDockingBay();
            _authorized = authorized;
        }

        public void Dock(string shipName)
        {
            if (_authorized)
                _realBay.Dock(shipName);
            else
                Debug.Log("Доступ запрещён к причалу для корабля: " + shipName);
        }
    }
}
