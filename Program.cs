using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemProject
{
    internal class Program
    {
        static int Health = 100;
        static int Shield = 100;
        static int Lives = 3;
        static int Healthcap = 100;
        static int Shieldcap = 100;
        static void Main(string[] args)
        {
            ShowHUD();
            TakeDamage(130);
            ShowHUD();
            Heal(40);
            ShowHUD();
            ShieldHeal(40);
            ShowHUD();
        }
        static void ShowHUD()
        {
            if (Health<=0){Lives-=1;Health=100;Shield=100;}YouDied();
            Console.WriteLine("INTERESTING GAME TITLE");
            Console.WriteLine(" | " + "Health:" + Health + " | " + "Shield:" + Shield + " | " + "Lives:" + Lives + " | ");
            Console.ReadKey(true);
            Console.Clear();
        }
        static void TakeDamage(int Damage)
        {
            Shield -= Damage;
            if (Shield < 0)
                Health = Health + Shield;
            if (Shield < 0)
                Shield = 0;
        }
        static void Reset()
        {
            Health = 100;
            Lives = 3;
            Shield = 100; 
        }
        static void YouDied()
        {
            if (Lives == 0)
            {
                Console.WriteLine("   You died! ");
                Console.WriteLine("----------------");
                Console.WriteLine("Restarting the game");
                Console.ReadKey(true);
                Reset();
            }
        }
        static void Heal(int HealAmount)
        {
            Console.WriteLine("You healed!");
            Health += HealAmount;
            if (Health > Healthcap)
                Health = Healthcap;
        }
        static void ShieldHeal(int HealAmount)
        {
            Console.WriteLine("You recovered shields!");
            Shield += HealAmount;
            if (Shield > Shieldcap)
                Shield = Shieldcap;
        }
    }
}