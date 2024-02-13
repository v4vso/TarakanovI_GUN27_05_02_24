

    //--------------------------------------------------------------------------------
public class Weapon
{
    public string Name { get; }
    private float _minDamage;
    private float _maxDamage;
    private Random _random;

    public float MinDamage => _minDamage;
    public float MaxDamage => _maxDamage;
    public float Damage => MinDamage + MaxDamage;

    //--------------------------------------------------------------------------------

    public Weapon(string name)
    {
        Name = name;
        _random = new Random();
    }

    public Weapon(string name, float minDamage, float maxDamage) : this(name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    public Weapon(string name, float damage) : this(name, damage, damage)
    {
    }

    public Weapon(float minDamage, float maxDamage)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    //--------------------------------------------------------------------------------

    private void SetDamageParams(float minDamage, float maxDamage)
    {
        if (minDamage > maxDamage)
        {
            Console.WriteLine($"Неправильные входные данные для оружия {Name}. Минимальный урон больше максимального. Значения будут заменены.");
            float temp = minDamage;
            minDamage = maxDamage;
            maxDamage = temp;
        }

        if (minDamage < 1f)
        {
            Console.WriteLine($"Принудительная установка минимального значения урона для оружия {Name}.");
            minDamage = 1f;
        }

        _minDamage = minDamage;
        _maxDamage = maxDamage;
    }

    //--------------------------------------------------------------------------------

    public float GetDamage()
    {
        return _random.Next((int)MinDamage, (int)MaxDamage);
    }
}
