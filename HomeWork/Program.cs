using System;

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
            //

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Подготовка к бою:");

            //

            Console.WriteLine("Введите имя бойца:");
            string name = Console.ReadLine();

            //

            Console.WriteLine("Введите начальное здоровье бойца (10-100):");
            float health = float.Parse(Console.ReadLine());

            //

            Console.WriteLine("Введите значение брони шлема от 0, до 1:");
            float helmArmor = float.Parse(Console.ReadLine());

            //

            Console.WriteLine("Введите значение брони кирасы от 0, до 1:");
            float shellArmor = float.Parse(Console.ReadLine());

            //

            Console.WriteLine("Введите значение брони сапог от 0, до 1:");
            float bootsArmor = float.Parse(Console.ReadLine());

            //

            Console.WriteLine("Укажите минимальный урон оружия (0-20):");
            float minWeaponDamage = float.Parse(Console.ReadLine());

            //

            Console.WriteLine("Укажите максимальный урон оружия (20-40):");
            float maxWeaponDamage = float.Parse(Console.ReadLine());

            //Unit

            Unit unit = new Unit(name);
            unit.Name = name;

            Helm helm = new Helm(helmArmor);
            unit.EquipHelm(helm);

            Shell shell = new Shell(shellArmor);
            unit.EquipShell(shell);

            Boots boots = new Boots(bootsArmor);
            unit.EquipBoots(boots);

            Weapon weapon = new Weapon("Оружие игрока", minWeaponDamage, maxWeaponDamage);
            unit.EquipWeapon(weapon);

            Console.WriteLine("Общий показатель брони равен: " + unit.Armor);
            Console.WriteLine("Фактическое значение здоровья равно: " + unit.RealHealth());
            Console.Read();
        }
    }
}