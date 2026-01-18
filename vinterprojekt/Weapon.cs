public class Weapon(string name, List<Attack> attacks, int baseDmg, int lvl = 0)
{
    public string Name { get; } = name;
    public List<Attack> Attacks { get; } = attacks;
    public int BaseDmg { get; } = baseDmg;
    public int Lvl { get; private set;} = lvl;

    private int attackOnThisLvl = 0;

    public int performAttack(Attack attack)
    {
        int damageModifier = Random.Shared.Next(attack.MinDmg, attack.MaxDmg);
        int damage = (BaseDmg + Lvl) * damageModifier;
        attackOnThisLvl++;
        if (attackOnThisLvl >= 10)
        {
            Lvl += 1;
            attackOnThisLvl = 0;
        } 
        return damage;
    }

    public void AddAttack(Attack attack)
    {
        Attacks.Add(attack);
    }
}

public class Sword : Weapon
{
    public static Weapon NoobSword() { return new Sword("Noob Swoord", 0, 0); }
    private static List<Attack> attacks = [
        new Attack(
            name: "Slash",
            minDmg: 9,
            maxDmg: 13,
            hitChance: 75
        )
    ];

    public Sword(string name, int baseDmg, int lvl = 0) : base(name, attacks, baseDmg, lvl) {}

};
