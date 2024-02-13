
//--------------------------------------------------------------------------------
// Struct Rate
struct Rate
{
    public Unit Unit { get; }
    public int Damage { get; }
    public double Health { get; }

    public Rate(Unit unit, int damage, double health)
    {
        // Set rate

        Unit = unit;
        Damage = damage;
        Health = Math.Round(health, 2); // Rounded to 2 decimal
    }
}

//--------------------------------------------------------------------------------
// class Combat

class Combat
{
    private List<Rate> rates; 

    public Combat()
    {
        rates = new List<Rate>(); //rates in constructor
    }

    public void StartCombat(Unit unit1, Unit unit2)
    {
        // Begin combat logic
        Random random = new Random();
        Console.WriteLine("Битва началась!");
        Console.WriteLine("***************");

        do
        {
            // calculating Damage for unit1

            int unit1Damage = random.Next((int)unit1.DamageInterval.Min, (int)(unit1.DamageInterval.Max + 1));
            unit2.Health -= unit1Damage;

            // re-calculating Damage for unit2

            int unit2Damage = random.Next((int)unit2.DamageInterval.Min, (int)unit2.DamageInterval.Max + 1);
            unit1.Health -= unit2Damage;

            // collecting Rate data for unit1

            Rate rate1 = new Rate(unit1, unit1Damage, unit1.Health);
            rates.Add(rate1); // adding rate to rates list

            // collecting Rate data for unit2

            Rate rate2 = new Rate(unit2, unit2Damage, unit2.Health);
            rates.Add(rate2); // adding rate to rates list

        } while (unit1.Health > 0 && unit2.Health > 0); // End combat
    }

    //--------------------------------------------------------------------------------
    //Results

    public void ShowResults()
    {
        
        

        foreach (Rate rate in rates)
        {
            //
            Thread.Sleep(1500);
            Console.Beep(200,75);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Боец: {rate.Unit.Name} урон: {rate.Damage} здоровье: {rate.Health}");
        }
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("****************");
        Console.WriteLine("Битва закончена!");
    }

}