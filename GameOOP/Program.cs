using System;
using System.Numerics;
using GameOOP;

namespace GameOOP
{

  
    class Program
    {
        static void Main(string[] args)
        {
            //POTION INITILIAZATION
            HealthPotion healthPotion = new HealthPotion("Healing Potion", "Red", 10);
            SpeedPotion speedPotion = new SpeedPotion("Speed Boost Potion", "Blue", 5);


            Console.WriteLine("Choose a weapon:");
            Console.WriteLine("1. Sword");
            Console.WriteLine("2. Bow");

            int choice = Convert.ToInt32(Console.ReadLine());

            Weapon weapon;

            if (choice == 1)
            {
                weapon = new Sword();
            }
            else
            {
                Console.WriteLine("Choose an arrow type:");
                Console.WriteLine("1. Poison");
                Console.WriteLine("2. Fire");
                Console.WriteLine("3. Ice");
                Console.WriteLine("4. Lightning");

                int arrowChoice = Convert.ToInt32(Console.ReadLine());

                ArrowType arrow;

                switch (arrowChoice)
                {
                    case 1:
                        arrow = ArrowType.Poison;
                        break;
                    case 2:
                        arrow = ArrowType.Fire;
                        break;
                    case 3:
                        arrow = ArrowType.Ice;
                        break;
                    case 4:
                        arrow = ArrowType.Lightning;
                        break;
                    default:
                        throw new Exception("Invalid arrow choice");
                }

                weapon = new Bow(arrow);
            }

            Console.WriteLine($"You chose: {weapon.Name}");
            Console.WriteLine($"Range: {weapon.Range} meters");
            Console.WriteLine($"Power: {weapon.Power}");

            if (weapon is Bow)
            {
                Bow bow = (Bow)weapon;
                Console.WriteLine($"Arrow type: {bow.Arrow}");
            }
            Dragon dragons = new Dragon();
            Wolf wolves = new Wolf();

            dragons.Health = 100;
            dragons.Power = 20;
            dragons.Speed = 5.0f;

            wolves.Health = 50;
            wolves.Power = 10;
            wolves.Speed = 3.0f;

            dragons.Update();
            wolves.Update();

            Player player = new Player("John", 5f, 10f, 100f, 0f, 0f);
            player.DisplayStats();
            player.Move(10f, 10f);
            player.Attack();
            player.TakeDamage(20f);
            player.DisplayStats();

            Console.WriteLine("Choose a character:");
            Console.WriteLine("1. Knight");
            Console.WriteLine("2. Archer");

            int choices = Convert.ToInt32(Console.ReadLine());

            HumanCharacter character;

            if (choice == 1)
            {
                character = new Knight(4.0f, 12.0f, 120);
                Console.WriteLine("You chose Knight!");
            }
            else if (choice == 2)
            {
                character = new Archer(6.0f, 8.0f, 100);
                Console.WriteLine("You chose Archer!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting...");
                return;
            }

            Console.WriteLine("Original Stats:");
            Console.WriteLine($"Speed: {character.Speed}");
            Console.WriteLine($"Power: {character.Power}");
            Console.WriteLine($"Health: {character.Health}");

            int damage = 20;
            Console.WriteLine($"Character is attacked for {damage} damage!");
            character.TakeDamage(damage);

            Console.WriteLine("Current Stats:");
            Console.WriteLine($"Power: {character.Power}");
            Console.WriteLine($"Health: {character.Health}");

            if (character is Knight)
            {
                ((Knight)character).Attack(30);
            }
            else if (character is Archer)
            {
                ((Archer)character).ShootArrow(25);
            }

            Console.ReadLine();
        }
    }
}

