// Im gonna make a story game about an adventurer. dont really know much of the story yet though so i will think it up along the way
// Firstly i need to make different choices like names and paths to choose.
// Than i need to make different endings so i have a game that is playable. 
// I think im going to make about 10 or more endings with different ways to achieve them.
// but first 3 endings an go to 10 endings.
// after i have made the endings and story im going to make improvements like maybe some items and damage systems.
// some improvements on the map maybe a type of map that you can check where you have went or what paths youve gone on.




using System.Text.RegularExpressions;



string print (string print)
{
    int Sleep = 75;
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
Thread.Sleep(1500);
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
Console.Write("You:");print(" My name is ");  playername = Console.ReadLine();

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
while (playername.Length< 4 || playername.Length> 16 || contains == true || !listan(playername))
{
    if (playername.Length< 4 || playername.Length> 16)
    {
        Console.Clear();
        print("The name has to be between 4 and 16 letters!"); 
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

List<int> playerdamage = [9, 12];
int Playerhealth = 75;
if (playername.Length >= 12)
{
    Playerhealth = 100;
}
if (playername.Length <= 6)
{
    Playerhealth = 50;
}



Dictionary<string, int> frogmoves = new Dictionary<string, int>
{
    ["Lick"] = Random.Shared.Next(5, 7),
    ["Groundslam"] = Random.Shared.Next(10, 13),
    ["Swallow"] = Random.Shared.Next(15, 18)

};
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
        int giantfrogdamage = Random.Shared.Next(5, 10);
        while (Playerhealth > 0 && Giantfroghealth > 0)
        {
            string attackchoice = "0";
            while (attackchoice != "1" && attackchoice != "2")
            {
                print("What attck do u use?");
                print("1. Punch [9-12]");
                print("2. Kick [12-15]");
                attackchoice = Console.ReadLine();
            }
            if (attackchoice == "1")
            {
                print("You use punch");
                int damage = Random.Shared.Next(playerdamage[0], playerdamage[1]);
                print($"You deal {damage} damage to the frog");
                Console.Write("Frog");print ($" {Giantfroghealth -= damage}");
                Console.Write("Frog");print($"Frog uses {frogmoves}");
            }
        }

    }
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