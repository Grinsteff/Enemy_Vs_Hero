
internal class Enemy
{
    Random random = new Random();
    public int hp = 120;
    public int dmg;
    public void damage()
    {
        dmg = random.Next(5, 35);
        hp = hp - dmg;
    }
    public void getdamage()
    {
        dmg = random.Next(5, 35);
        hp = hp - dmg;
    }
}
internal class Character
{
    Random random = new Random();
    public int hp = 100;
    public const int maxhp = 100;
    public int dmg;
    public int aid;
    public void damage()
    {
        dmg = random.Next(5, 35);
        hp = hp - dmg;
    }
    public void getdamage()
    {
        dmg = random.Next(5, 35);
        hp = hp - dmg;
    }
    public void heal()
    {
        aid = random.Next(5, 35);
        hp = hp + aid;
        if (hp >= maxhp)
        {
            hp = maxhp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            Character character = new Character();
            Console.WriteLine("В этой до ужаса простой игре вам нужно победить противника нанося ему урон, так же вы можете использовать аптечки чтобы немного пополнить ваше здоровье");
            while (enemy.hp > 0 && character.hp > 0)
            {
                Console.WriteLine($"1 - Ударить противника, 2 - Использовать аптечку");
                string a = Console.ReadLine();
                int convA = Convert.ToInt32(a);
                if (convA == 1)
                {
                    enemy.getdamage();
                    character.getdamage();
                    Console.WriteLine($"Вы нанесли противнику {enemy.dmg}\n Здоровье противника: {enemy.hp}");
                    Console.WriteLine($"Противник нанес вам {character.dmg}\n Ваше здоровье: {character.hp}");
                }
                if (convA == 2)
                {
                    character.getdamage();
                    Console.WriteLine($"Противник нанес вам {character.dmg}\n Ваше здоровье: {character.hp}");
                    character.heal();
                    Console.WriteLine($"Вы использовали аптечку, вылечив свое здоровье на {character.aid} ваше здоровье теперь {character.hp}");
                }


            }
            if (enemy.hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ПОБЕДА!!!");
            }
            else if (character.hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU DIED");
            }
            else if (character.hp <= 0 && enemy.hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("НИЧЬЯ");
            }
        }
    }
}