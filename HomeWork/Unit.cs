


//-------------------------------------------------------------------------------------------
public class Unit
{
    public Unit(string name, float health, 
        Helm helm, Shell shell, 
        Boots boots, Weapon weapon, 
        Interval damageInterval)
    {
        Name = name;
        Health = health;
        Helm = helm;
        Shell = shell;
        Boots = boots;
        Weapon = weapon;
        DamageInterval = damageInterval;
    }

    public string Name { get; }
    private float _health;

    public float Health
    {
        get => _health;
        set => _health = value < 0 ? 0 : value;
    }

    //-------------------------------------------------------------------------------------

    public Interval DamageInterval { get; set; }

    public int HealthInt => (int)Math.Floor(Health);

    public float Damage => Weapon != null ? Weapon.Damage + BaseDamage : BaseDamage;

    public float Armor
    {
        get
        {
            float helmArmor = Helm != null ? Helm.ArmorValue : 0;
            float shellArmor = Shell != null ? Shell.ArmorValue : 0;
            float bootsArmor = Boots != null ? Boots.ArmorValue : 0;

            float totalArmor = helmArmor + shellArmor + bootsArmor;

            totalArmor = Math.Clamp(totalArmor, 0, 1);

            return totalArmor;
        }
    }

    //------------------------------------------------------------------------

    public float RealHealth => Health * (1f + Armor);

    public bool SetDamage(float value)
    {
        Health -= value * Armor;

        return Health <= 0f;
    }

    private const float BaseDamage = 5;
    public Weapon Weapon { get; set; }
    public Helm Helm { get; set; }
    public Shell Shell { get; set; }
    public Boots Boots { get; set; }

    //--------------------------------------------------------------------------------

    public Unit() : this("Unknown Unit", 100)
    {
    }

    public Unit(string name) : this(name, 100)
    {
    }

    public Unit(string name, float health)
    {
        Name = name;
        Health = health;
    }

    //Equip

    public void EquipWeapon(Weapon weapon)
    {
        Weapon = weapon;
    }
    public void EquipHelm(Helm helm)
    {
        Helm = helm;
    }

    public void EquipShell(Shell shell)
    {
        Shell = shell;
    }

    
    public void EquipBoots(Boots boots)
    {
        Boots = boots;
    }

    //--------------------------------------------------------------------------------

    public struct Interval
    {
        public double MinValue { get; }
        public double MaxValue { get; }

        //Interval
        //-------------------------------------------------------------------------------------------------

        public Interval(double minValue, double maxValue)
        {
            if (minValue > maxValue)
            {
       
                MinValue = maxValue;
                MaxValue = minValue;
                Console.WriteLine("Неверный ввод: minValue больше maxValue. Значения поменялись местами.");
            }
            else
            {
                MinValue = minValue;
                MaxValue = maxValue;
            }
        }


        //Interval
        //-------------------------------------------------------------------------------------------------

        public Interval(double value) : this(value, value)
        {
        }

        public double GetRandomNumber()
        {
            Random random = new Random();
            return random.Next((int)MinValue, (int)MaxValue);
        }

        public double Min => MinValue;

        public double Max => MaxValue;

        public double Average => (MinValue + MaxValue) / 2;

        public override string ToString()
        {
            return $"Interval({MinValue}, {MaxValue})";
        }
    }
}
