using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bossfight
{
    internal class GameCharacter
    {
        int playerHealth = 100;
        int playerStam = 40;

        int bossHealth = 400;
        int bossStam = 10;
   

        public static void Fight(int playerHealth, int playerStam, int bossHealth, int bossStam)
        {
            while (playerHealth > 0 && bossHealth > 0)
            {
                Console.WriteLine("The player has   " + playerHealth + " health  " + playerStam + " Stam");
                Console.WriteLine("The enemy has   " + bossHealth + " health   " + bossStam + " Stam");
                Console.WriteLine("Press 1 to attack. The first one to zero health loses.");
                string choice = Console.ReadLine();
                int bossStrength = new Random().Next(0, 30);
                int playerStrength = new Random().Next(0, 20);

                if (choice == "1")
                {
                    playerStam -= 10;
                    Console.WriteLine("The boss fights back with  " + bossStrength + "  damage!");
                    Console.WriteLine("You fight back with  " + playerStrength + "  damage!");
                    playerHealth -= bossStrength;
                    bossHealth -= playerStrength;

                }

                if (playerStam == 0)
                {
                    Recharge(playerStam += 40);
                } 


                if (playerHealth < 0 || bossHealth < 0)
                {
                    Console.WriteLine("Game over due to sudden death");
                    
                }
            }

        }
        public static void Recharge(int playerStam)
        {
            Console.WriteLine("Stamina too low. Waiting to recharge");
            Thread.Sleep(1000);

        }
    }
}

