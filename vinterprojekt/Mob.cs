public class Mob(string name, int health, List<Attack> attacks)
{
    public string Name { get; } = name;
    public int Health { get; set; } = health;
    public List<Attack> Attacks { get; } = attacks;

    public bool isItDeadYet() { return Health <= 0; }
};

