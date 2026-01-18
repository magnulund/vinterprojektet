public class Attack(string name, int minDmg, int maxDmg, int hitChance)
{
    public string Name { get; } = name;
    public int MinDmg { get; } = minDmg;
    public int MaxDmg { get; } = maxDmg;
    public int HitChance { get; } = hitChance;
}
