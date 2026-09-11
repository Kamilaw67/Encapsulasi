using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek karakter
            Character hero = new Character();

            // Mengakses atribut (perhatikan access modifier)
            hero.characterID = "C-001";
            // hero.characterName = "Arthas";   // Apakah ini bisa? (Error karena protected)
            // hero.characterClass = "Warrior"; // Apakah ini bisa? (Bisa karena internal dalam 1 assembly)
            // hero.health = 100;               // Apakah ini bisa? (Error karena private)
            // hero.level = 1;                  // Apakah ini bisa? (Error karena private)

            // Memanggil method
            hero.Start();
            hero.TakeDamage(30);
            hero.Heal(10);

            // Mencoba memanggil method private dari luar class
            // hero.LevelUp();                  // Apakah ini bisa? (Error karena private)

            hero.ShowStats();

            Console.ReadKey();
        }
    }
}