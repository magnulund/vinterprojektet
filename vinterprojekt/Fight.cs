
public class Fight
{
    public static void DoTheFight(Dictionary<string, int> enemyattack,Dictionary<string, int> playerattack, 
    List<int> playerHitChances, List<int> enemyhitchances, List<string>pDicValues,
    int enemyhealth, int Playerhealth, string playername)
    {

        while(Playerhealth >= 0 && enemyhealth >= 0)
        {
            
            string attackchoice = "0";
            while (attackchoice != "1" && attackchoice != "2")
            {
                Console.WriteLine("What attack do u use?");
                for (int i = 0; i < playerattack.Count; i++)
                {
                    KeyValuePair<string, int> playerdictionary = playerattack.ElementAt(i);
                    Console.WriteLine($"{i+1} {playerdictionary.Key} {pDicValues.ElementAt(i)} [hitchance = {100 - playerHitChances.ElementAt(i)}]"); 
                };
                attackchoice = Console.ReadLine();
            }

            int.TryParse(attackchoice, out int playerattackint); 
            KeyValuePair<string, int> playerattack1 = playerattack.ElementAt(playerattackint-1);
            if (attackchoice == "1" || attackchoice == "2")
            {
                Console.Clear();
                Console.WriteLine($"You use {playerattack1.Key }");

                int playerhitchance = Random.Shared.Next(0, 10001)/100;

                if (playerhitchance >= playerHitChances[playerattackint-1])
                {
                Console.WriteLine($"You deal {playerattack1.Value} damage to the frog");
                Console.Write("Frog health: ");Console.WriteLine ($" {enemyhealth -= playerattack1.Value}");
                }
                else if (playerhitchance < playerHitChances[playerattackint-1])
                {
                    Console.WriteLine("You missed");
                }
                if (enemyhealth <= 0)
                {
                    break;
                }

                int r = Random.Shared.Next(0, enemyattack.Count);

                KeyValuePair<string, int> frogattack = enemyattack.ElementAt(r);

                Console.Write("Frog");Console.WriteLine($" uses {frogattack.Key}");
                
                int froghitchance = Random.Shared.Next(0, 10001)/100;

                if(froghitchance >= enemyhitchances[r])
                {
                    Console.WriteLine($"You take {frogattack.Value} damage");
                    Playerhealth -= frogattack.Value;
                }
                
                else if(froghitchance < enemyhitchances[r])
                {
                    Console.WriteLine("The frog misses");
                }
                

                Console.Write("Frog health:");Console.WriteLine($" {enemyhealth}");
                Console.Write(playername); Console.WriteLine($" {Playerhealth}");
            }
        }

    }
}