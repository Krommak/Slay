namespace Game.Stats.Unit
{
    public class UnitStats
    {
        private int _hp;
        private int _armor;
        private int _damage;
        private int _movementSpeed;

        public UnitStats(int hp, int armor, int damage, int movementSpeed)
        {
            _hp = hp;
            _armor = armor;
            _damage = damage;
            _movementSpeed = movementSpeed;
        }
    }
}