using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemProject
{
    internal class Program
    {
        static Random RNDDamage = new Random();
        static int Health = 100;
        static int Shield = 100;
        static int Lives = 3;
        static int Healthcap = 100;
        static int Shieldcap = 100;

        static void Main(string[] args)
        {
            ShowHUD();
            Console.WriteLine("Testing spill damage");
            TakeDamage(210);
            ErrorChecks();
            ShowHUD();
            Console.WriteLine("Testing negative damage");
            TakeDamage(-50);
            ErrorChecks();
            ShowHUD();
            Console.WriteLine("Testing normal heal");
            Heal(10);
            ErrorChecks();
            ShowHUD();
            Console.WriteLine("Testing over heal");
            Heal(110);
            ErrorChecks();
            ShowHUD();
        }

        static void ErrorChecks()
        {
            if (Shield > Shieldcap)
                Console.WriteLine("You can't input negative numbers.");
                Shield = 100;

            if (Health > Healthcap)
                Console.WriteLine("You can't input negative numbers.");
                Health = 100;

            Console.ReadKey(true);
        }
        static void ShowHUD()
        {

            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("INTERESTING GAME TITLE");
            Console.WriteLine(" | " + "Health:" + Health + " | " + "Shield:" + Shield + " | " + "Lives:" + Lives + " | ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ReadKey(true);
        }

        static void TakeDamage(int Damage)
        {
            Console.WriteLine("Player is about to take " + Damage + " damage");
            Console.ReadKey(true);
            
            if (Damage < 0)
            {
                Console.WriteLine("You can't input negative numbers.");
                Health += Damage;
            }

            Shield -= Damage;
            if (Shield < 0)
                Health = Health + Shield;
            if (Shield < 0)
                Shield = 0;


        }
        static void TakeDamageRND()
        {
            int Damage;
            Damage = RNDDamage.Next(10,51);
            Console.WriteLine("Player is about to take " + Damage + " damage");
            Console.ReadKey(true);

            Shield -= Damage;
            if (Shield < 0)
                Health = Health + Shield;
            if (Shield < 0)
                Shield = 0;

            if (Damage < 0)
            {
                Console.WriteLine("You can't input negative numbers.");
            }

        }
        static void TakeDamageDev()
        {
            int Damage = 0;
            Console.WriteLine("How much damage are you taking?");
            
            try
            {
                Damage = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine("That's not an integer.");
            }

            
            Console.WriteLine("Player is about to take " + Damage + " damage");
            Console.ReadKey(true);

            Shield -= Damage;
            if (Shield < 0)
                Health = Health + Shield;
            if (Shield < 0)
                Shield = 0;

            if (Damage < 0)
            {
                Console.WriteLine("You can't input negative numbers.");
                Health += Damage;
            }

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
        static void HealDev()
        {
            int HealAmount = 0;
            Console.WriteLine("How much health are you healing?");

            try
            {
                HealAmount = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine("That's not an integer.");
            }

            Console.WriteLine("Player is about to heal " + HealAmount + " health");
            Console.ReadKey(true);

            Health += HealAmount;
            if (Health > Healthcap)
                Health = Healthcap;

        }
        static void Heal(int HealAmount)
        {
            Console.WriteLine("You are about to heal " + HealAmount + " health");
            Health += HealAmount;
            if (Health > Healthcap)
                Health = Healthcap;
        }

        static void ShieldHealDev()
        {
            int HealAmount = 0;
            Console.WriteLine("How much shield are you healing?");

            try
            {
                HealAmount = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine("That's not an integer.");
            }

            Console.WriteLine("Player is about to heal " + HealAmount + " shield");
            Console.ReadKey(true);

            Shield += HealAmount;
            if (Shield > Shieldcap)
                Shield = Shieldcap;

        }
        static void ShieldHeal(int HealAmount)
        {
            Console.WriteLine("You recovered shield!");
            Shield += HealAmount;
            if (Shield > Shieldcap)
                Shield = Shieldcap;

        }
            }
        }
