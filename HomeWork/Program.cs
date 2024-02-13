
//--------------------------------------------------------------------------------

using static Unit;


namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {


            //ASCII
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Unit Tool (HomeWork)");
            Console.WriteLine(@"
                            llllllllllllllllllllllllllllllllllllllll
                            lllllllllllllllllllc:cllllllllllllllllll
                            llllllllllllc:,'.':,.'::;:clllllllllllll
                            llllllllllcccc:...'...,::;;,:lllllllllll
                            llllllllll:clc;..'....':ccc,';clllllllll
                            lllllllllccc;,:::c;;;;:;'';;,'clllllllll
                            llllllllllc;,;;:loc;;;,'..,:ccclllllllll
                            llllllllllc,...','.......,'':lllllllllll
                            lllllllllc:......'....   .,.':llllllllll
                            lllllllllc,..;'.,,'.'.....,,.;llllllllll
                            llllccclc:..':'':;...''..;l;.,cllcclllll
                            lllllllccc;',,,',,..',,...,'.;llclllllll
                            lllllllcl:,'';'.';..','....,,:ccclllllll
                            lcccccccc;,;:;. .,...''..,.,:ccccclcccll
                            lccccccc;;cc:'. .'..''...;;;ccccccccclll
                            ccccccc;,:cc;'...;,;:;'..,:ccccccccccccc
                            cccccc:,;ccc;'..':::c;'...;c::::::;;:ccc
                            ccccc:,;:::;,'..';;;;;,'..,;;;;;;;;;;;;;
                            ccccc;,::::;,'..',,,,,;:,.,,,,;;;;;;;;::
                            cccc:;:c:::;,,,,;;;;;;,,,.',,;::;;;,;:cl
                            ccc:;:ccc:;;;;::::::::;:;,;:::ccccc::cll
                            lccccc::;;;:ccccccccccccccccccccllllllll
                            lccccc;;:cccccccccccccccccccllllllllllll");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.Read();
            Console.Clear();

            //--------------------------------------------------------------------------------
            Console.WriteLine("Подготовка к бою:");

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите имя бойца:");
            string? name = Console.ReadLine();

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите начальное здоровье бойца (10-100):");

            int health = int.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите значение брони шлема от 0 до 1:");

            float helmArmor = float.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите значение брони кирасы от 0 до 1:");

            float shellArmor = float.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите значение брони сапог от 0 до 1:");

            float bootsArmor = float.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------

            Console.WriteLine("Укажите минимальный урон оружия (0-20):");

            float minDamage = float.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------

            Console.WriteLine("Укажите максимальный урон оружия (20-40):");

            float maxDamage = float.Parse(Console.ReadLine());

            //--------------------------------------------------------------------------------

            Unit player = new Unit(name, health, new Helm(helmArmor), new Shell(shellArmor), new Boots(bootsArmor), new Weapon(minDamage, maxDamage), new Interval(15, 25));

            //

            Console.WriteLine("Общий показатель брони равен: " + player.Armor);

            //
            Console.WriteLine("Фактическое значение здоровья равно: " + player.RealHealth);

            //--------------------------------------------------------------------------------

            Unit unit1 = new Unit("Боец 1", 75, new Helm(helmArmor), new Shell(shellArmor), new Boots(bootsArmor), new Weapon(minDamage, maxDamage), new Interval(10, 27));
            Unit unit2 = new Unit("Боец 2", 85, new Helm(helmArmor), new Shell(shellArmor), new Boots(bootsArmor), new Weapon(minDamage, maxDamage), new Interval(3, 25));

            //--------------------------------------------------------------------------------

            Console.WriteLine($"Боец 1: {unit1.Name}, Здоровье: {unit1.Health}, Интервал урона: {unit1.DamageInterval.Min}-{unit1.DamageInterval.Max}");
            Console.WriteLine($"Боец 2: {unit2.Name}, Здоровье: {unit2.Health}, Интервал урона: {unit2.DamageInterval.Min}-{unit2.DamageInterval.Max}");

            Combat combat = new Combat();
            combat.StartCombat(unit1, unit2);

            combat.ShowResults();



            Console.ReadLine();

        }
    }
}