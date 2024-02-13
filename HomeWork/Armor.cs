
//--------------------------------------------------------------------------------

public class Armor
{
    private const float MinArmorValue = 0f;
    private const float MaxArmorValue = 1f;

    private readonly string name;
    private float armorValue;

    public string Name => name;

    public float ArmorValue
    {
        get => armorValue;
        set
        {
            armorValue = Math.Clamp(value, MinArmorValue, MaxArmorValue);
            if (armorValue != value)
            {
                Console.WriteLine("Указано неверное значение брони. Значение настройки в диапазоне от 0 до 1.");
            }
        }
    }

    //--------------------------------------------------------------------------------

    public Armor(string name)
    {
        this.name = name;
        InitializeArmorValue();
    }

    private void InitializeArmorValue()
    {
        switch (name.ToLower())
        {
            case "helm":
                armorValue = new Helm().ArmorValue;
                break;

            case "shell":
                armorValue = new Shell().ArmorValue;
                break;

            case "boots":
                armorValue = new Boots().ArmorValue;
                break;

            default:
                Console.WriteLine("Неверное имя брони. Установка значения по умолчанию.");
                armorValue = 0.5f;
                break;
        }
    }
}

//--------------------------------------------------------------------------------

public class Helm
{
    public Helm(float helmArmor)
    {
        ArmorValue = helmArmor;
    }
    public float ArmorValue { get; private set; }

    public Helm()
    {
        ArmorValue = 0.5f;
    }
}

public class Shell
{
    public Shell(float shellArmor)
    {
        ArmorValue = shellArmor;
    }

    public float ArmorValue { get; private set; }

    public Shell()
    {
        ArmorValue = 0.8f;
    }
}

public class Boots
{
    public Boots(float bootsArmor)
    {
        ArmorValue = bootsArmor;
    }

    public float ArmorValue { get; private set; }

    public Boots()
    {
        ArmorValue = 0.3f;
    }
}

//--------------------------------------------------------------------------------

public static class MathExtensions
{
    public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
    {
        if (value.CompareTo(min) < 0)
            return min;
        else if (value.CompareTo(max) > 0)
            return max;
        else
            return value;
    }
}
