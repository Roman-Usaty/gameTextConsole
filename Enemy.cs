using System;

namespace gemeTextConsole
{
    class Enemy
    {
		private int HealthPoint;
		private int StrongPoint;
		private int ShieldPoint;
		private readonly string[] NameEnemy = new string[3] { "Skeleton", "Spider", "Slime" };
		private string name;

		public void SetName()
		{
			var rand = new Random();
			int randInt = rand.Next(0, 2);

            name = NameEnemy[randInt];
		}

        public string GetName() => name;

        public int GetHealth() => HealthPoint;

        public void SetPoint()
		{
			var rand = new Random();

			if (name == "Skeleton")
			{
				HealthPoint = rand.Next(35, 60);
                StrongPoint = rand.Next(10, 25);
				ShieldPoint = rand.Next(2, 6);
			}
			else if (name == "Spider")
			{
				HealthPoint = rand.Next(20, 55);
				StrongPoint = rand.Next(7, 20);
				ShieldPoint = rand.Next(5, 8);
			}
			else
			{
				HealthPoint = rand.Next(10, 30);
				StrongPoint = rand.Next(1, 6);
				ShieldPoint = rand.Next(10, 200);
			}
		}
        public int GetShield() => ShieldPoint;
        public double GetDamage()
		{
			var rand = new Random();
            double damage = Math.Floor(StrongPoint * 2 * rand.NextDouble());
			return damage;
		}

        public void GiveDamage(int damage) => HealthPoint -= damage;
    }
}
