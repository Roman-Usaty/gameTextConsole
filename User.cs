using System;

namespace gemeTextConsole
{
    class User
    {
        private int HealthPoint = 100;
		private readonly int UserStrong = 15;
		private readonly int ShieldPoint = 30;
		private string Name;

        public int GetHealth() => HealthPoint;

        public int GetShield() => ShieldPoint;

        public void EnemyDamage(int damage) => HealthPoint -= damage;

        public void SetName(string Name) => this.Name = Name;
        public string GetName() => Name;

        public double Punch(int shieldEnem)
        {
            var rand = new Random();
            return Math.Floor(((UserStrong * 2) - shieldEnem) * rand.NextDouble());
        }
    }
}
