// Im gonna make a story game about an adventurer who got teleported in to a tower that has different levels and you have to find a way out
// Firstly i need to make different choices like names and paths to choose.
// Than i need to make different endings so i have a game that is playable. 
// I think im going to make about 10 or more endings with different ways to achieve them.
// but first 3 endings an go to 10 endings.
// after i have made the endings and story im going to make improvements like maybe some items and damage systems.
// some improvements on the map maybe a type of map that you can check where you have went or what paths youve gone on.



using System.Text.RegularExpressions;

string print (string print)
{
    
    for (int i = 0; i <print.Length; i++)
    {
        Console.Write(print[i]);
        Thread.Sleep(75);
    }
    Console.WriteLine();
    return print;

}

//Här är introt till spelet.
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
    print("Start the game?");
    print("Dont start?");
    start = Console.ReadLine();
    
}
Console.Clear();
print("You're walking to work on a monday morning when suddenly a wierd circle appears underneath your feet.");
Thread.Sleep(500);
print("You're falling through the air at high speeds, the ground a few hundred meters below.");
Thread.Sleep(500);
print("Just a few meters above the ground now and BOOM!");
Thread.Sleep(2000);
print("a few hours later: You wake up no scratch to be found, but you remeber falling hundreds of meters...");
Thread.Sleep(500);
print("You wonder how you could have no scratches on your body as you hear a voice speaking to you from behind");
Console.Clear();
print("Hello there! How are you sir?");
Thread.Sleep(500);
print("1. Tell him that your fine?");
print("2. Tell him that you fell from a high place and somehow survived?");

string choice1 = Console.ReadLine();
while(choice1 != "1" && choice1 != "2")
{
    print("Hello there! How are you sir?");
    print("1. Tell him that your fine?");
    print("2. Tell him that you fell from a high place and somehow survived?");
    choice1 = Console.ReadLine();
}
if (choice1 == "1")
{
    print("You say 'Im fine how about you sir?'");
    Thread.Sleep(2000);
    print("Im good just wandering about when i saw you here");
}
else if (choice1 == "2")
{
    print("You explain what happened and how you fell and woke up here.");
    Thread.Sleep(3000);
    print("Whoa thats really wierd... What are you?... well no matter now,");
}
print("What is your name sir?");
//namnet som spelaren måste välja.
string playername = Console.ReadLine();

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
        print("The name has to be between 4 and 16 letters!"); 
        playername = Console.ReadLine();
    }
    if (contains == true || listan(playername) == false)
    {
        print("The name can only contain standard letters!");
        playername = Console.ReadLine();
        contains = Regex.IsMatch(playername, @"[^\w]");
    }       
    
}

print($"What a strange name, say where are you from sir {playername}?");








