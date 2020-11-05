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
                    Console.WriteLine("Нажмите F, что бы продолжить");
                    string butt = Console.ReadLine();
                    if (butt == "F" | butt == "f")
                    {
                        Main();
                    }

                }
                else
                {
                    double damageEnem = enemy.GetDamage();

                    var rand = new Random();

                    if (rand.Next(1,100) <= 50)
                    {
                        Console.WriteLine("{0} наносит вам {1} урона", enemy.GetName(), damageEnem);
                        user.EnemyDamage((int)damageEnem);

                        Console.WriteLine("У вас остается {0}", user.GetHealth());
                        int damageUser = (int)user.Punch(enemy.GetShield());

                        enemy.GiveDamage(damageUser);

                        Console.WriteLine("Вы наносите {0} урона, и у врага остается - {1} hp", damageUser, enemy.GetHealth());

                        Do(user, enemy);
                    } else
                    {
                        var enemyBoss = new EnemyTest();

                        

                        while (enemyBoss.GetHealth > 0)
                        {
                            Console.WriteLine("{0} наносит вам {1} урона", enemyBoss.GetName(), damageEnem);
                            user.EnemyDamage((int)damageEnem);

                            if (user.GetHealth < 0)
                            {
                                Do(user, enemyBoss);
                            }

                            Console.WriteLine("У вас остается {0}", user.GetHealth());
                            int damageUser = (int)user.Punch(enemyBoss.GetShield());

                            enemyBoss.GiveDamage(damageUser);

                            Console.WriteLine("Вы наносите {0} урона, и у врага остается - {1} hp", damageUser, enemyBoss.GetHealth());
                        }
                        
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("You lose");
                Console.WriteLine("Нажмите F, что бы продолжить");
                string butt = Console.ReadLine();
                if (butt == "F" | butt == "f")
                {
                    Main();
                }
                
            }
        }
	}
}
