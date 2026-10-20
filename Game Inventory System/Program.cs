

namespace Game_Inventory_System
{
    class Weapon
    {
        public int Id;
        public string Name;
        public int Damage;
        public Weapon(int id, string name, int damage)
        {
            Id = id;
            Name = name;
            Damage = damage;
        }
    }
        class Player
        {
            public string Name;
           public  List<Weapon> weapons = new List<Weapon>();
            public Player(string name)
            {
                Name = name;
            }
            public void AddWeapon(Weapon weapon)
            {
                weapons.Add(weapon);
            }
        }
        class Program
    {
       
        static void Main(string[] args)
        {
            Player player1 = new Player("Ahmed");
            Player player2 = new Player("Omar");
            player1.AddWeapon(new Weapon(1, "Sword", 50));
            player1.AddWeapon(new Weapon(2, "Bow", 30));
            player2.AddWeapon(new Weapon(3, "Axe", 70));
            Console.WriteLine($"player: {player1.Name} ");
            Console.WriteLine($"Total Weapons: {player1.weapons.Count}");
            for(int i = 0; i < player1.weapons.Count; i++)
            {
                Console.WriteLine($"ID: {player1.weapons[i].Id} | {player1.weapons[i].Name} | Damage: {player1.weapons[i].Damage}");
            }
            Console.WriteLine("===============================");
            Console.WriteLine($"player: {player2.Name}");
            Console.WriteLine($" Total Weapons: {player2.weapons.Count}");
            for (int i = 0; i < player2.weapons.Count; i++)
            {
                Console.WriteLine($"ID: {player2.weapons[i].Id} | {player2.weapons[i].Name} | Damage: {player2.weapons[i].Damage}");
            }


        }
    }
}
