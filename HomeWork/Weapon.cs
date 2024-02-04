public class Weapon
{
    public string Name { get; }
    public float MinDamage { get; private set; }
    public float MaxDamage { get; private set; }

    //

    public Weapon(string name)
    {
        Name = name;
    }

    public Weapon(string name, float minDamage, float maxDamage) : this(name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    //

    public void SetDamageParams(float minDamage, float maxDamage)
    {
        if (minDamage > maxDamage)
        {
            var temp = minDamage;
            minDamage = maxDamage;
            maxDamage = temp;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name}: Неправильные входные данные, minDamage был больше maxDamage. Значения поменялись местами.");
        }

        if (minDamage < 1f)
        {
            minDamage = 1f;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name}: MinDamage был меньше 1. Он был установлен на 1.");
        }

        if (maxDamage <= 1f)
        {
            maxDamage = 10f;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name}: MaxDamage был меньше или равен 1. Он был установлен на 10.");
        }

        MinDamage = minDamage;
        MaxDamage = maxDamage;
    }

    //GetDamage

    public float GetDamage()
    {
        return (MinDamage + MaxDamage) / 2;
    }
}