


public class Fight(
    string enemyName, int enemyHealth, List<Attack> enemyAttacks, 
    string playerName, int playerHealth, List<Attack> playerAttacks
    )
{
    private readonly List<Attack> enemyAttacks = enemyAttacks;
    private readonly List<Attack> playerAttacks = playerAttacks;
    private int enemyHealth = enemyHealth;
    private int playerHealth = playerHealth;
    private readonly string playerName = playerName;
    private readonly string enemyName = enemyName;

    public void DoTheFight()
    {
        while(playerHealth >= 0 && enemyHealth >= 0)
        {
            static string print (string printer)
            {
                int Sleep = 25;
                for (int i = 0; i <printer.Length; i++)
                {
                    Console.Write(printer[i]);
                    Thread.Sleep(Sleep);
                    
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        { 
                            Sleep = 0;
                        }   
                    }
                }
                Console.WriteLine("");
                return printer;

            }



            string attackchoice = "0";
            while (attackchoice != $"{playerAttacks.Count}"&& attackchoice != "1" && attackchoice != "2")
            {
                print("What attack do u use?");
                int i = 1;
                foreach (Attack a in playerAttacks)
                {
                    print($"{i} {a.Name} ({a.MinDmg}-{a.MaxDmg}) [hitchance = {100 - a.HitChance}]");
                    i++;
                };
                attackchoice = Console.ReadLine();
            }

            int.TryParse(attackchoice, out int playerattackint); 
            Attack attack = playerAttacks[playerattackint-1];
            if (attack is not null)
            {
                Console.Clear();
                print($"You use {attack.Name}");

                int playerhitchance = Random.Shared.Next(0, 10001)/100;

                if (playerhitchance <= attack.HitChance)
                {
                    int damage = Random.Shared.Next(attack.MinDmg, attack.MaxDmg);
                    enemyHealth = (damage < enemyHealth) ? enemyHealth -= damage : 0;

                    print($"You deal {damage} damage to the {enemyName}");
                    Console.Write($"{enemyName} health: ");
                    print($" {enemyHealth}");
                }
                else
                {
                    print("You missed");
                }

                if (enemyHealth <= 0)
                {


                    print($"\n You defeated {enemyName}! \n"); 

                    break;
                }

                int enemyChoice = Random.Shared.Next(0, enemyAttacks.Count);

                Attack enemyAttack = enemyAttacks[enemyChoice];

                Console.Write(enemyName);print($" uses {enemyAttack.Name}");
                
                int enemyHitChance = Random.Shared.Next(0, 10001)/100;

                if(enemyHitChance >= enemyAttack.HitChance)
                {
                    int damage = Random.Shared.Next(enemyAttack.MinDmg, enemyAttack.MaxDmg);
                    playerHealth = (damage < playerHealth) ? playerHealth -= damage : 0;
                    print($"You take {damage} damage");
                }
                else
                {
                    print($"The {enemyName} misses");
                }

                Console.Write($"{enemyName} health:");print($" {enemyHealth}");
                Console.Write(playerName); print($" {playerHealth}");
                if (playerHealth <= 0)
                {
                    break;
                }
            }
        }

    }
}