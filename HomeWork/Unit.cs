public class Unit
{
    private const float baseDamage = 5f;
    private Weapon weapon;
    private Helm helm;
    private Shell shell;
    private Boots boots;
    private float health = 100f;

    //

    public string Name { get; set; }
    public float Health => health;
    public float Damage => (weapon != null ? weapon.GetDamage() : 0f) + baseDamage;
    public float Armor
    {
        get
        {
            float sum = 0f;
            if (helm != null)
                sum += helm.Armor;
            if (shell != null)
                sum += shell.Armor;
            if (boots != null)
                sum += boots.Armor;
            return MathF.Round(sum, 2);
        }
    }

    //Unit

    public Unit() : this("Unknown Unit")
    {

    }

    public Unit(string name)
    {
        Name = name;
    }

    public float RealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float amt)
    {
        health -= amt * Armor;
        return health <= 0f;
    }

    //

    public void EquipWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void EquipHelm(Helm helm)
    {
        this.helm = helm;
    }

    public void EquipShell(Shell shell)
    {
        this.shell = shell;
    }

    public void EquipBoots(Boots boots)
    {
        this.boots = boots;
    }
}