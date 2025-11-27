// Im gonna make a story game about an adventurer. dont really know much of the story yet though so i will think it up along the way
// Firstly i need to make different choices like names and paths to choose.
// Than i need to make different endings so i have a game that is playable. 
// I think im going to make about 10 or more endings with different ways to achieve them.
// but first 3 endings an go to 10 endings.
// after i have made the endings and story im going to make improvements like maybe some items and damage systems.
// some improvements on the map maybe a type of map that you can check where you have went or what paths youve gone on.




using System.Text.RegularExpressions;


int Sleep = 75;
string print (string print)
{

    for (int i = 0; i <print.Length; i++)
    {
        Console.Write(print[i]);
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
    Sleep = 75;
    return print;
}

//Här är introt till spelet.
Console.WriteLine("To skip dialogues press spacebar:");
Thread.Sleep(500);
print("1. Start the game?");
print("2. Dont start?");
string start = Console.ReadLine();
if (start != "1" && start != "2")
{
    print("ill take that as a yes..");
    Thread.Sleep(500);
}
while(start == "2")
{
    print("Are you sure?");
    print("1. Start the game?");
    print("2. Dont start?");
    start = Console.ReadLine();
    if (start != "1" && start != "2")
    {
    print("ill take that as a yes..");
    Thread.Sleep(500);
    }
    
}
Console.Clear();
print("You're walking to work on a monday morning when suddenly a wierd circle appears underneath your feet.");
Thread.Sleep(500);
print("You're falling through the air at high speeds, the ground a few hundred meters below.");
Thread.Sleep(500);
print("Just a few meters above the ground now and BOOM!");
Thread.Sleep(750);
print("a few hours later: You wake up no scratch to be found, but you remeber falling hundreds of meters...");
Thread.Sleep(500);
print("You wonder how you could have no scratches on your body as you hear a voice speaking to you from behind");
Thread.Sleep(500);
Console.Clear();
Console.Write("Mysterious man:");print(" Hello there! How are you sir?");
Thread.Sleep(500);
print("1. Tell him that your fine?");
print("2. Tell him that you fell from a high place and somehow survived?");

string choice1 = Console.ReadLine();
while(choice1 != "1" && choice1 != "2")
{
    Console.Clear();
    Console.Write("Mysterious man:");print(" Hello there! How are you sir?");
    print("1. Tell him that your fine?");
    print("2. Tell him that you fell from a high place and somehow survived?");
    choice1 = Console.ReadLine();
}
if (choice1 == "1")
{
    Console.Write("You:");print(" Im fine how about you sir?");
    Thread.Sleep(2000);
    Console.Write("Mysterious man:");print(" Im good just wandering about when i saw you here. now,");
}
else if (choice1 == "2")
{
    print("You explain what happened and how you fell and woke up here.");
    Thread.Sleep(3000);
    Console.Write("Mysterious man:"); print("Whoa thats really wierd... What are you?... well no matter. now,");
}
Console.Write("Mysterious man:");print(" What is your name sir?");
//namnet som spelaren måste välja.
string playername;
Console.Write("You:");print(" My name is ");  
playername = Console.ReadLine();

//fick hjälp med denna bit{ 
var contains = Regex.IsMatch(playername, @"[^\w]");
// }
List<string> numbers = ["1", "2", "3" ,"4", "5", "6", "7", "8", "8", "9"]; 
bool listan(string str)
{
    foreach (char chr in str)
    {
        if (numbers.Contains(chr.ToString()))
        {
            return false;
        }
    }
    return true;
}
//kollar om namnet är en viss längd och om det inte har några konstiga täcken.
while (playername.Length< 3 || playername.Length> 20 || contains == true || !listan(playername))
{
    if (playername.Length< 3 || playername.Length> 20)
    {
        Console.Clear();
        print("The name has to be between 3 and 20 letters!"); 
        playername = Console.ReadLine();
    }
    if (contains == true || listan(playername) == false)
    {
        Console.Clear();
        print("The name can only contain standard letters!");
        playername = Console.ReadLine();
        contains = Regex.IsMatch(playername, @"[^\w]");
    }       
    
}
Console.Clear();
Console.Write("You:");print($"My name is {playername}");
Thread.Sleep(500);
Console.Write("Mysterious man:");Thread.Sleep(100);print($" What a strange name, say where are you from sir {playername}?");
print("1. Tell him youre from another world?");
print("2. Tell him you don't know?");
string homeplace = Console.ReadLine();
while (homeplace != "1" && homeplace != "2")
{
    Console.Clear();
    print("1. Tell him youre from another world?");
    print("2. Tell him you don't know?");
}
if (homeplace == "1")
{
    Console.Write("You:");print(" I am from a world much more advanced than this world and i do not know how i appeared here but i know one thing for sure... i must get back there.");
    Console.Write("Mysterious man:");print(" ");
}
else if (homeplace == "2")
{
    Console.Write("You:");print(" i dont know.");
    Console.Write("Mysterious man:");print(" How strange... well would you like to follow me back to my home?");
}
int Playerhealth = 75;
if (playername.Length >= 14)
{
    Playerhealth = 100;
}
if (playername.Length <= 6)
{
    Playerhealth = 50;
}
print("1. Go home with the kind man?");
print("2. Walk along a different road and try to find your own way");
string pathchoice0 = Console.ReadLine();
while (pathchoice0 != "1" && pathchoice0 != "2")
{
    pathchoice0 = Console.ReadLine();
}
if (pathchoice0 == "2")
{
    print("You walk along a road surrounded by trees when a giant frog suddenly appears!");
    print("1. Attack it?");
    print("2. Run away?");
    string giantfrogchoice1 = Console.ReadLine(); 
    while (giantfrogchoice1 != "1" && giantfrogchoice1 != "2")
    {
        print("1. Attack it?");
        print("2. Run away?");
        giantfrogchoice1 = Console.ReadLine();
    }
    if (giantfrogchoice1 == "1")
    {
        int Giantfroghealth = 50;
        Console.Write("Frog: "); print("ribbit*");
        Console.Write("Frog");print($" {Giantfroghealth}");
        Console.Write(playername); print($" {Playerhealth}");
        while (Playerhealth >= 0 && Giantfroghealth >= 0)
        {
            Dictionary<string, int> frogmoves = new ()
            {
                ["Lick"] = Random.Shared.Next(5, 7),
                ["Groundslam"] = Random.Shared.Next(10, 13),
                ["Swallow"] = Random.Shared.Next(15, 18)
            };
            Dictionary<string, int> playermoves = new()
            {
                ["Punch"] = Random.Shared.Next(9, 12),
                ["Kick"] = Random.Shared.Next(15, 18)
            };

            List<int> playerhitchances = [25, 50];

            List<int> Froghitchances =  [25, 50, 65];

            string attackchoice = "0";
            while (attackchoice != "1" && attackchoice != "2")
            {
                print("What attack do u use?");
                print("1. Punch [9-12]");
                print("2. Kick [15-18]");
                attackchoice = Console.ReadLine();
            }
            int.TryParse(attackchoice, out int playerattackint); 
            KeyValuePair<string, int> playerattack = playermoves.ElementAt(playerattackint-1);
            if (attackchoice == "1" || attackchoice == "2")
            {
                Console.Clear();
                print($"You use {playerattack.Key }");

                int playerhitchance = Random.Shared.Next(1, 10000)/100;

                if (playerhitchance >= playerhitchances[playerattackint-1])
                {
                print($"You deal {playerattack.Value} damage to the frog");
                Console.Write("Frog");print ($" {Giantfroghealth -= playerattack.Value}");
                }
                else if (playerhitchance < playerhitchances[playerattackint-1])
                {
                    print("You missed");
                }
                if (Giantfroghealth <= 0)
                {
                    
                    break;
                }

                int r = Random.Shared.Next(0, frogmoves.Count);

                KeyValuePair<string, int> frogattack = frogmoves.ElementAt(r);

                Console.Write("Frog");print($" uses {frogattack.Key}");
                int froghitchance = Random.Shared.Next(1, 10000)/100;

                if(froghitchance >= Froghitchances[r])
                {
                    print($"You take {frogattack.Value} damage");
                    Playerhealth -= frogattack.Value;
                }
                
                else if(froghitchance < Froghitchances[r])
                {
                    print("The frog misses");
                }
                

                Console.Write("Frog");print($" {Giantfroghealth}");
                Console.Write(playername); print($" {Playerhealth}");
            }
        }
        if (Playerhealth <= 0)
        {
            print("You died...");
        }
        if (Giantfroghealth <= 0)
        {
            print("You won your first fight YAY!!!");
        }
        print("You keep walking down the road for a couple hours");
        print("Just up ahead there is a plain hill with no trees around it.");
        print("You go to it and on the hill you see a city far away in the distance.");
        print("A few hours later...");
        print("The city is now towering before you and a gate seems to appear further along the walls");

    }

    if (giantfrogchoice1 == "2")
    {
        Console.Write("You:"); print("gulp* RUN!!!!!!!!!!!!");
        print("You run away from the frog");
    }

}
if (pathchoice0 == "1")
{
    print("You start walking along with the man travelling for a few hours.");
    print("A city starts to appear in the distance");
    Console.Write("Mysterious man: ");print("This is the city of galmingdor");
    Console.Write("You: ");print("WoW..." );
    Console.Write("You: ");print("How long till we get there?");
    Console.Write("Mysterious man: ");print("About an hour");
    print("As you start to walk again the ground shakes and a roar is heard in the distance");
    Console.Write("You: ");  print("What was that!??!?!");
    Console.Write("Mysterious Man: ");print("That was an underground dragon... ");
    Console.Write("Mysterious Man: ");print("It should be fine though as i have never heard of an underground dragon going to the surface");

}



string pathchoice1 = Console.ReadLine();
while (pathchoice1 != "1" && pathchoice1 != "2")
{
    pathchoice1 = Console.ReadLine();
} 

string pathchoice2 = Console.ReadLine();
while (pathchoice2 != "1" && pathchoice2 != "2")
{
    pathchoice2 = Console.ReadLine();
}

string pathchoice3 = Console.ReadLine();
while (pathchoice3 != "1" && pathchoice3 != "2")
{
    pathchoice3 = Console.ReadLine();
}

string pathchoice4 = Console.ReadLine();
while (pathchoice4 != "1" && pathchoice4 != "2")
{
    pathchoice4 = Console.ReadLine();
}

string pathchoice5 = Console.ReadLine();
while (pathchoice5 != "1" && pathchoice5 != "2")
{
    pathchoice5 = Console.ReadLine();
}

string pathchoice6 = Console.ReadLine();
while (pathchoice6 != "1" && pathchoice6 != "2")
{
    pathchoice6 = Console.ReadLine();
}

string pathchoice7 = Console.ReadLine();
while (pathchoice7 != "1" && pathchoice7 != "2")
{
    pathchoice7 = Console.ReadLine();
}

string pathchoice8 = Console.ReadLine();
while (pathchoice8 != "1" && pathchoice8 != "2")
{
    pathchoice8 = Console.ReadLine();
}

string pathchoice9 = Console.ReadLine();
while (pathchoice9 != "1" && pathchoice9 != "2")
{
    pathchoice9 = Console.ReadLine();
}








Console.ReadLine();