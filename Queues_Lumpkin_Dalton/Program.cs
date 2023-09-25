// See https://aka.ms/new-console-template for more information
using Queues_Lumpkin_Dalton;


Game myGame = new Game(50, 49);

Queue<Player> waitingToJoinQ = new Queue<Player>();

Player p1 = new Player(100, "MMSix");
Player p2 = new Player(100, "N7_Dalton");
Player p3 = new Player(100, "NMC_M1st");
Player p4 = new Player(100, "Agent1245321");

p1.JoinGame(myGame, waitingToJoinQ);
p2.JoinGame(myGame, waitingToJoinQ);
p3.JoinGame(myGame, waitingToJoinQ);
p4.JoinGame(myGame, waitingToJoinQ);

Console.WriteLine("Player in da q:");
foreach(Player player in waitingToJoinQ)
{
    Console.WriteLine(player);
}

myGame.KickPlayer();
myGame.CheckQueue(waitingToJoinQ);


Console.WriteLine("\nPlayer in da q:");
foreach (Player player in waitingToJoinQ)
{
    Console.WriteLine(player);
}