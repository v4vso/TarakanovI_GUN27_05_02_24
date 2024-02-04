public abstract class ArmorPiece
{
    public string Name { get; }

    private float armor;

    //
    public float Armor
    {
        get
        {
            return armor;
        }
        set
        {
            if (value < 0f)
            {
                armor = 0f;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Значение не может быть меньше 0. Броня установлена на 0.");
            }
            else if (value > 1f)
            {
                armor = 1f;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Значение не может быть больше 1. Броня установлена на 1.");
            }
            else
            {
                armor = value;
            }
        }
    }

    //

    protected ArmorPiece(string name, float armor)
    {
        Name = name;
        Armor = armor;
    }
}

//Helm,Shell,Boots

public class Helm : ArmorPiece
{
    public Helm(float armor) : base("Helm", armor)
    {
    }
}

public class Shell : ArmorPiece
{
    public Shell(float armor) : base("Shell", armor)
    {
    }
}

public class Boots : ArmorPiece
{
    public Boots(float armor) : base("Boots", armor)
    {
    }
}