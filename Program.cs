using System;

namespace gemeTextConsole
{
    class Program
    {
        static void Main(string[] args)
        {
			var user = new User();

			Console.WriteLine("Введите имя:");
			user.SetName(Console.ReadLine());

			var enem = new Enemy();
			enem.SetName();
			enem.SetPoint();

			Console.WriteLine("У вас {0} hp", user.GetHealth());
			Console.WriteLine("Вы встретели {0} - он враг! У него {1} hp.", enem.GetName(), enem.GetHealth());

			Do(user, enem);
            Console.ReadKey();
		}
		public static void Do(User user, Enemy enemy)
		{
            if (user.GetHealth() >= 0)
            {
                if (enemy.GetHealth() <= 0)
                {
                    Console.WriteLine("You win");
                }
                else
                {
                    double damageEnem = enemy.GetDamage();

                    Console.WriteLine("{0} наносит вам {1} урона", enemy.GetName(), damageEnem);
                    user.EnemyDamage((int)damageEnem);

                    Console.WriteLine("У вас остается {0}", user.GetHealth());
                    int damageUser = (int)user.Punch(enemy.GetShield());

                    enemy.GiveDamage(damageUser);

                    Console.WriteLine("Вы наносите {0} урона, и у врага остается - {1} hp", damageUser, enemy.GetHealth());

                    Do(user, enemy);
                }
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
	}
}
