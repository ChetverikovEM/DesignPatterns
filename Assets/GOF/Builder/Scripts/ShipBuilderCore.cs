namespace Builder
{
    public class ShipBuilder
    {
        private string _name;
        private bool _weapons;
        private bool _shields;

        // Задание имени корабля
        public ShipBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        // Добавление вооружения
        public ShipBuilder AddWeapons()
        {
            _weapons = true;
            return this;
        }

        // Добавление щитов
        public ShipBuilder AddShields()
        {
            _shields = true;
            return this;
        }

        // Финальное создание объекта
        public SpaceShip Build()
        {
            return new SpaceShip(_name, _weapons, _shields);
        }
    }
}
