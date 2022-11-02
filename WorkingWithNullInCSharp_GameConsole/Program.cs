// See https://aka.ms/new-console-template for more information
using WorkingWithNullInCSharp_GameConsole;
 


var player = new PlayerCharacter();
player.Name = "Sarah";
//player.DaysSinceLastLogin = 0;

PlayerDisplayer.Write(player);

Console.ReadLine();