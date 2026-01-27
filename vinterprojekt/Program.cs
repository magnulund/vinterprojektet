// Im gonna make a story game about an adventurer. dont really know much of the story yet though so i will think it up along the way
// Firstly i need to make different choices like names and paths to choose.
// Than i need to make different endings so i have a game that is playable. 
// I think im going to make about 10 or more endings with different ways to achieve them.
// but first 3 endings an go to 10 endings.
// after i have made the endings and story im going to make improvements like maybe some items and damage systems.
// some improvements on the map maybe a type of map that you can check where you have went or what paths youve gone on.




//while (Console.KeyAvailable)
//{
//Console.Write("");
//if (Console.ReadKey(true).Key == ConsoleKey.Enter)
//{ 
//    break;
//  }   
//}


using System.Text.RegularExpressions;


int Sleep = 25;
string print (string printer)
{
    
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
    Sleep = 25;
    return printer;

}


string restartChoice = "";
//Här är introt till spelet.

while (true)
{ 

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
        Console.Write("Mysterious man:");print(" Im good just wandering about when i saw you here. now,");
    }
    else if (choice1 == "2")
    {
        print("You explain what happened and how you fell and woke up here.");
        Console.Write("Mysterious man:"); print("Whoa thats really wierd... What are you?... well no matter. now,");
    }
    Console.Write("Mysterious man:");print(" What is your name sir?");
    //namnet som spelaren måste välja.
    string playerName;
    Console.Write("You:");print(" My name is ");  
    playerName = Console.ReadLine();

    //fick hjälp med denna bit{ 
    var contains = Regex.IsMatch(playerName, @"[^\w]");
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
    while (playerName.Length< 3 || playerName.Length> 20 || contains == true || !listan(playerName))
    {
        if (playerName.Length< 3 || playerName.Length> 20)
        {
            Console.Clear();
            print("The name has to be between 3 and 20 letters!"); 
            playerName = Console.ReadLine();
        }
        if (contains == true || listan(playerName) == false)
        {
            Console.Clear();
            print("The name can only contain standard letters!");
            playerName = Console.ReadLine();
            contains = Regex.IsMatch(playerName, @"[^\w]");
        }       
    
    }
    Console.Clear();
    Console.Write("You:");print($"My name is {playerName}");
    Thread.Sleep(500);
    Console.Write("Mysterious man:");Thread.Sleep(100);print($" What a strange name, say where are you from sir {playerName}?");
    print("1. Tell him youre from another world?");
    print("2. Tell him you don't know?");
    string homeplace = Console.ReadLine();
    while (homeplace != "1" && homeplace != "2")
    {
        Console.Clear();
        print("1. Tell him youre from another world?");
        print("2. Tell him you don't know?");
        homeplace = Console.ReadLine();
    }
    if (homeplace == "1")
    {
        Console.Write("You:");print(" I am from a world much more advanced than this world and i do not know how i appeared here but i know one thing for sure... i must get back there.");
        Console.Write("Mysterious man:");print(" Wow... that is indeed something... well for now would you like to come with me?");
    }
    else if (homeplace == "2")
    {
        Console.Write("You:");print(" i dont know.");
        Console.Write("Mysterious man:");print(" How strange... well would you like to follow me back to my home?");
    }
    int playerHealth = 75;
    if (playerName.Length >= 14)
    {
        playerHealth = 50;
    }
    if (playerName.Length <= 6)
    {
        playerHealth = 100;
    }
    print("1. Go home with the kind man?");
    print("2. Walk along a different road and try to find your own way");
    string pathchoice0 = Console.ReadLine();
    while (pathchoice0 != "1" && pathchoice0 != "2")
    {
        pathchoice0 = Console.ReadLine();
        print("1. Go home with the kind man?");
        print("2. Walk along a different road and try to find your own way");
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
        int giantFrogHealth = 50;
        Mob giantFrog = new Mob(
            name: "Giant Frog",
            50,
            [
                new Attack(
                    name: "Lick",
                    minDmg: 5,
                    maxDmg: 7,
                    hitChance: 75
                ),
                new Attack(
                    name: "Groundslam",
                    minDmg: 10,
                    maxDmg: 13,
                    hitChance: 50
                ),
                new Attack(
                    name: "Swallow",
                    minDmg: 15,
                    maxDmg: 18,
                    hitChance: 35
                ),
            ]
        );
        Console.Write($"{giantFrog.Name}: "); print("ribbit*");
        Console.Write($"{giantFrog.Name}");print($" {giantFrog.Health}");
        Console.Write(playerName); print($" {playerHealth}");
        List<Attack> playerAttacks = [
            new Attack(
                name: "Punch",
                minDmg: 9,
                maxDmg: 13,
                hitChance: 75
            ),
            new Attack(
                name: "Kick",
                minDmg: 15,
                maxDmg: 19,
                hitChance: 50
            ),
        ];

        Fight frogFight = new Fight(giantFrog.Name, giantFrog.Health, giantFrog.Attacks, playerName, playerHealth, playerAttacks);
        frogFight.DoTheFight();

        

            
        if (giantFrogHealth <= 0)
        {
            print("You won your first fight YAY!!!");
            print("New move aquired (tackle)");
        }
        print("You keep walking down the road for a couple hours");
        print("Just up ahead there is a plain hill with no trees around it.");
        print("You go to it and on the hill you see a city far away in the distance.");
        print("A few hours later...");
        print("The city is now towering before you and a gate seems to appear further along the walls");
        print("At the city gate a guard is standing on duty");
        print("You approach");
        Console.Write("Guard: "); print("HALT! Who are you? and what is your purpose in galmingdor");   
        Console.Write("You: ");print($"i am {playerName}");
        print("1. My purpose here is to destroy the place muahhahahah");
        print("2. My purpose here is to gather information about this world");
        print("3. I do not yet know my purpose here but i am sure i will find out");
        string purpose = Console.ReadLine();
        while(purpose != "1" && purpose != "2" && purpose != "3")
        {
            Console.WriteLine("");
            print("1. My purpose here is to destroy the place muahhahahah");
            print("2. My purpose here is to gather information about this world");
            print("3. I do not yet know my purpose here but i am sure i will find out");
            purpose = Console.ReadLine();
        }



        if (purpose == "1")
        {
            Console.Write("You: ");print("My purpose is to destroy this place muahhahaha you shall kneel to me!!!");
            Console.Write("Guard: ");print("Than ill kill you now to stop you villain.");
            print("The guard attacks you");



            Mob Guard = new Mob(
                name: "Guard",
                120,
                [
                    new Attack(
                        name: "Shieldbash",
                        minDmg: 20,
                        maxDmg: 23,
                        hitChance: 50
                    ),
                    new Attack(
                        name: "SwordStrike",
                        minDmg: 25,
                        maxDmg: 30,
                        hitChance: 75
                    ),
                    
                    new Attack(
                        name: "Heabyslash",
                        minDmg: 35,
                        maxDmg: 38,
                        hitChance: 35
                    )
                ]
            );
            playerAttacks.Add(new Attack(
                name: "Tackle",
                minDmg: 20,
                maxDmg: 25,
                hitChance: 40
            ));
            Fight guardFight = new Fight(Guard.Name, Guard.Health, Guard.Attacks, playerName, playerHealth, playerAttacks);
            guardFight.DoTheFight();


            if (playerHealth <= 0)
            {
                print("You lose!");
            
                print("1. Want to restart?");
                print("2. Want to quit?");
                restartChoice = Console.ReadLine();
                while (restartChoice != "1" && restartChoice != "2")
                {
                    print("1. Want to restart?");
                    print("2. Want to quit?");
                    restartChoice = Console.ReadLine();
                }
                if( restartChoice == "2")
                {
                    break;            
                } 
                if(restartChoice == "1")
                {
                    continue;
                }
            };
            
            
            if  (Guard.Health <= 0)
            {
                print("You somehow won you lucky bastard");
                print("New ability aquired (Uprising)");
                print("You hear bells sounding and people screaming and the ground starts shaking as a squadron of soldiers approach the gate you stand at.");
                print("You have only a few seconds before they arrive and kill you");
                print("But what can you do its not like you have any move for this...");
                print("BUT WAIT the new ability you aquired... we wont know unless we try");
                print("1. Use it");
                print("2. Accept ur fate and die");
                string winchoice1 = Console.ReadLine();
                while (winchoice1 != "1" && winchoice1 != "2")
                {   
                    print("1. Use it");
                    print("2. Accept ur fate and die");
                    winchoice1 = Console.ReadLine();        
                }       
                if (winchoice1 == "1")
                {
                    Console.Clear();
                    print("Nothing happens and you see the squadron approaching rappidly towards you.");
                    print("in a few seconds you will be dead...");
                    Thread.Sleep(1500);
                    print("But than suddenly the gravity seems to change upside down and you start falling");
                    print("Everything begins corrupting arround you a black fog with red border seems to swallow everything up...");
                    print("Its pitch black in every direction when suddenly a white light starts to appear");
                    print("You go towards it and when you get there you return to the same old boring monday morning in the exakt same spot");       
                    print("Nothing seems to have changed but you can still remember everything that has happened");
                    Thread.Sleep(750);
                    print("You have won the game!!!");
                    print("Would you like to play again?");
                    print("1. Yes");
                    print("2. No");
                    restartChoice = Console.ReadLine();
                    while (restartChoice != "1" && restartChoice != "2")
                    {
                        print("1. Want to restart?");
                        print("2. Want to quit?");
                        restartChoice = Console.ReadLine();
                    }
                    if( restartChoice == "2")
                    {
                        break;           
                    } 
                    if(restartChoice == "1")
                    {
                        continue;
                    }
                } 
            } 
            if (purpose == "2")
            {
                Console.Write("You: "); print("My purpose here is to gather information about the world"); 
                Console.Write("Guard: ");print("Well that seems like a good thing to do atleast you arent here to destroy the place hah");
                Console.Write("You: ");print("Who would ever even think of doing something like that hahah");
                Console.Write("Guard: ");print("Yeah, i mean it happened once before when a great mage came here and tried to destroy the place");
                Console.Write("Guard: ");print("Well here is your pass anyway now go find your information");
                Console.Write("You: ");print("Thanks ill get going than");
            }
            if (purpose == "3")
            {
                Console.Write("You: ");print("I do not yet know what my purpose is here but i am hoping to find out");
                Console.Write("Guard: ");print("Well sounds suspicious but ill give you the pass anyway");
                Console.Write("You: ");print("I thank thy humble guard for this oppurtunity");
                Console.Write("Guard: ");print("Move along now");
            }
        }

    }

    if (giantfrogchoice1 == "2")
        {
            Console.Write("You:"); print("gulp* RUN!!!!!!!!!!!!");
            print("You run away from the frog");
            print("You run along a pathway and cath up to the man you were talking to.");
            print("He leads you to a city that he calls galmingdor.");
            print("He tells you to go along in to the city before him.");
            print("And than he goes up to the guard and tells him that you are a friend of his.");
            print("You head through the gate on the wall of the city.");
        }

    }
    if (pathchoice0 == "1")
    {
        Console.Clear();
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
        print("You keep walking and arrive in the city a little while later");
        print("At the city gate the man speaks with the guard and than calls to you");
        Console.Write("Mysterious Man: ");print("Come here! we can get through now and ill show you the city");
        Console.Write("???: "); print("hey Ingur come here i need help with something");
        Console.Write("Ingur: ");print($"Well i have to go {playerName} see you later, sorry i couldn't show you around");

    }

    print("There are 3 streets leading in different directions: left, right, forward");
    print("1. Left");
    print("2. Right");
    print("3. Forward");
    string pathchoice1 = Console.ReadLine();
    while (pathchoice1 != "1" && pathchoice1 != "2" && pathchoice1 != "3")
    {
        print("1. Left");
        print("2. Right");
        print("3. Forward");
        pathchoice1 = Console.ReadLine();
    } 
    if(pathchoice1 == "1")
    {
        print("You start walking left passing some houses and vendors");
        print("One of the vendors catches your eye");
        print("Do you go to him or keep going past him");
        print("1. Go to the vendor");
        print("2. Keep walking");
        string vendor = Console.ReadLine();
        while(vendor != "1" && vendor != "2")
        {
            print("1. Go to the vendor");
            print("2. Keep walking");
            vendor = Console.ReadLine();
        }
        int playercoins = 25;
        while(vendor == "1")
        {
            Dictionary<string, int> shop = new()
            {
              ["Iron sword"] = 20,
              ["Shield"] = 15,
              ["Mysterious box"] = 2  
            };

            Console.Write("Vendor: ");print("Hello there sir what would you like to buy");
            print("Stock:");
            for (int i = 0; i<shop.Count; i++)
            {
                KeyValuePair<string, int> shopping = shop.ElementAt(i);
                print($"{i+ 1}. {shopping.Key}, [{shopping.Value} coins]");    

            }
            string buy = Console.ReadLine();
            while (buy != "1" && buy != "2" && buy != "3")
            {
                print("Stock:");
                for (int i = 0; i<shop.Count; i++)
                {
                    KeyValuePair<string, int> shopping = shop.ElementAt(i);
                    print($"{i+ 1}. {shopping.Key}, [{shopping.Value} coins]");
                }
                buy = Console.ReadLine();
            }
            int.TryParse(buy, out int buyint);

            KeyValuePair<string, int> shopprice = shop.ElementAt(buyint - 1);
            if (playercoins < shopprice.Value)
            {
                Console.Write("Vendor: ");print("Dont got the money means no more shopping");
                Console.Write("Vendor: ");print("Now scram, i have other customers");
                vendor = "2";
            }
            if((buy == "1"|| buy == "2"|| buy == "3") && playercoins >= shopprice.Value)
            {
                Console.Write("Vendor: ");print($"Ah, you want the {shopprice.Key} ");
                Console.Write("You: ");print("Yes i do");
                print($"You hand the man {shopprice.Value} coins");
                playercoins -= shopprice.Value;
                print($"You now have {playercoins} coins left");
                Console.Write("Vendor: "); print("Anything else");
                print("1. Keep shopping");
                print("2. Walk further along the path");
                vendor = Console.ReadLine();
                while(vendor != "1" && vendor != "2")
                {
                    print("1. Keep shopping");
                    print("2. Walk further along the path");
                    vendor = Console.ReadLine();
                }
            }
            


        }
        print("You keep walking going further along the road untill you come to a crossing");
        print("Do you go left or right?");
        print("1. Left");
        print("2. Right");
        string walkchoice = Console.ReadLine();
        while (walkchoice != "1" && walkchoice != "2")
        {
            print("1. Left");
            print("2. Right");
            walkchoice = Console.ReadLine();
        }
        if (walkchoice == "1")
        {
            print("You go left only to stumble into a dead end");
            print("So you go back and walk right instead");
            walkchoice = "2";
        }
        if (walkchoice == "2")
        {
            print("You walk right and go on for a while till you see a town square");
            print("People are looking up to the sky");
            Console.Write("Random citizen: ");print("AHHHHHHHH!!!!!!");
            print("A dragon flies past and goes toward the castle in the center of the town.");
            print("BOOOM!!!!");
            print("The town turned to a fiery blaze the castle flying to bits in the sky and people screaming everywhere");
            print("You get hit by a rock flying toward you");
            print("You fall to the ground and lay unconscious for a few hours");
            print("You wake up to find the town still in flames guards running around and loud screams from the townspeople.");
            print("You start running somewhere you dont know where you are yet but you see an open area");
            print("You find a sword laying on the ground probably from a vendor");
            print("Do you pick it up?");
            print("1. Pick it up");
            print("2. Leave it");
            string swordchoice = Console.ReadLine();
            while(swordchoice != "1" && swordchoice != "2")
            {
                print("1. Pick it up");
                print("2. Leave it");
            }
            if(swordchoice == "1")
            {
                print("You pick up the sword");
                Dictionary<string, int> playermoves = new()
                {
                    ["Flash step"] = Random.Shared.Next(15, 18),
                    ["Sword SLash"] = Random.Shared.Next(20, 27),
                    ["Overhead slash"] = Random.Shared.Next(30, 38),
                    ["Tackle"] = Random.Shared.Next(20, 25)
                };
                List<int> hitchances = [0, 12, 25, 45];
                print("You feel a surge of power running through your veins");
                print("");

            }
        }
        

    }
    string companionchoice = Console.ReadLine();
    if (pathchoice1 == "2")
    {
        print("You start walking along the right path");
        print("The road starts getting narrower and narrower homeless people all around laying on the ground.");
        print("You see in an alley that some thugs are harrasing someone");
        print("Do you go to help or do you go past");
        print("1. Help the person");
        print("2. Walk past");
        string helpchoice = Console.ReadLine();
        while (helpchoice != "1" && helpchoice != "2")
        {
            helpchoice = Console.ReadLine();
        }
        if (helpchoice == "1")
        {
            print("You go over to help the person");
            Console.Write("Thug 1; ");print("HEY GIVE US ALL YOUR MONEY PALL");
            Console.Write("Mysterious person; ");print("I already gave you everthing");
            Console.Write("Thug 2; ");print("HEY YOU THERE, move along");
            Console.Write("You; ");print("Sorry that aint happening pall now stop harrasing this person or ill call the guards");
            Console.Write("Thug 2; ");print("Alright well leave for now");
            print("They start leaving and the mysterious person starts getting up from the ground.");
            Console.Write("Mysterious person; ");print("Thank you sir what do i owe you");
            Console.Write("You; ");print("Nothing really i just wanted to help out");
            Console.Write("Mysterious person; ");print("Atleast tell me your name, my name is Alfina");
            Console.Write("You; "); print($"My name is {playerName}");
            Console.Write("Alfina; ");print($"{playerName} i would like to accompany you for a while if you are okay with it");

            print("1. Let her accompany you");
            print("2. Decline her offer");

            while (companionchoice != "1" && companionchoice != "2")
            {
                print("1. Let her accompany you");
                print("2. Decline her offer");
                companionchoice = Console.ReadLine();
            }
            if (companionchoice == "1")
            {
                Console.Write("You; ");print("Fine com along then");
            }
            if(companionchoice == "2")
            {
                Console.Write("You; ");print("No sorry i have plans");
                Console.Write("Alfina; ");print("Just one day and i will be happy");
                Console.Write("You; ");print("Fine but only one day");
                Console.Write("Alfina; ");print("Yay, where are we going?");
            }

        }
        if (helpchoice == "2")
        {
            print("You walk past the alleyway and hear screaming behind you");
            print("The thugs are running out of there and you start walking a bit faster");
            print("A voice starts coming out of the alley and they seem to be looking for something or maybe someone.");
            Console.Write("Mysterious person: ");print("Hey you there!");
            print("You start walking just a bit faster and the voice seems to be coming closer");
            Console.Write("Mysterious person: ");print("You dont walk away from me, HEY!");
            print("You freeze as if you cant walk anymore someone is stopping you from walking.");
            print("You feel a hand on your shoulder");
            Console.Write("Mysterious person: ");print("You there, why were you trying to run away from me?");
            Console.Write("You: ");print("What??, i would never i was just hurrying to see my friend");
            Console.Write("Mysterious person: ");print("oooohhh, so you are saying you werent walking faster when i called out to you?");
            Console.Write("You: ");print("Yeah thats what i am saying i thought you were calling on someone else...");
            Console.Write("Mysterious person: ");print("There is absolutely no one else here right now...");
            Console.Write("Mysterious person: ");print("I think your gonna have to come with me now im taking you to my place.....");
            Console.Write("You: ");print("Do I have a choice? ");
            Console.Write("Mysterious person: ");print("No... you dont have a choice in this...");
            print("You try and run but your body is still frozen and the mysterious person knocks you out.");
            print("You wake up a few hours later in a cell with iron bars.");
            Console.Write("Mysterious person: ");print("Finally woke up have we?");
            Console.Write("You: ");print("");            
        }
        print("Right");
    }
    if (pathchoice1 == "3")
    {
        print("Forward");
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

}

