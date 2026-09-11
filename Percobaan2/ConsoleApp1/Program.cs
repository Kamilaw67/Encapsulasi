using System;

namespace GameEncapsulationDemo
{
    public class Character
    {
        // Atribut dengan berbagai access modifier
        public string characterID = "067";
        public string characterName = "Jamron";
        public string characterClass = "Ayam";
        public float health;
        public int level;

        //konstruktor berparameter
        public Character()
        {
            characterID = "UNKNOWN";
            characterName = "Hero";
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Default.");
        }

        public Character(int initialLevel)
        {
            level = initialLevel;
        }

        // 2. Konstruktor Berparameter (2 parameter)
        public Character(string id, string name)
        {
            characterID = id;
            characterName = name;
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Berparameter (ID & Nama).");
        }

        // 3. Konstruktor Berparameter (3 parameter)
        public Character(string id, string name, string classType)
        {
            characterID = id;
            characterName = name;
            characterClass = classType;
            health = 100;
            level = 1;
            Console.WriteLine($"Objek Character dibuat dengan Konstruktor Berparameter (ID, Nama, & Class).");
        }

        // Method
        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {characterName} (Level {level}) memulai petualangan!");
        }

        private void LevelUp()
        {
            level++;
            Console.WriteLine($"{characterName} naik level! Level sekarang: {level}");
            // Tambah health maksimal, dll.
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{characterName} menerima {dmg} damage. Health tersisa: {health}");
            if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur.");
            }
        }

        public void Heal(float healAmt)
        {
            health += healAmt;
            Console.WriteLine($"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}");
        }

        public void ShowStats()
        {
            Console.WriteLine("\n=== STATS KARAKTER ===");
            Console.WriteLine($"ID     : {characterID}");
            Console.WriteLine($"Nama   : {characterName}");
            Console.WriteLine($"Class  : {characterClass}");
            Console.WriteLine($"Level  : {level}");
            Console.WriteLine($"Health : {health}");
        }
    }
}