using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO STATIC & INSTANCE ===\n");

            // Menampilkan jumlah karakter sebelum membuat objek
            Console.WriteLine($"Total Karakter saat ini: {Character.GetTotalCharacterCount()}");

            // Membuat beberapa objek Character
            Character hero1 = new Character();
            Character hero2 = new Character("C-002", "Liara");
            Character hero3 = new Character("C-003", "Garrosh", "Orc Warrior");

            // Menampilkan stats masing-masing objek
            hero1.ShowStats();
            hero2.ShowStats();
            hero3.ShowStats();

            // Menampilkan jumlah karakter setelah membuat objek
            Console.WriteLine($"\nTotal karakter yang telah dibuat: {Character.GetTotalCharacterCount()}");

            Console.ReadKey();
        }
    }
}