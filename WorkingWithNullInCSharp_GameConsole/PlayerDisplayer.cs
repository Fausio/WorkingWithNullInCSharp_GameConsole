using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNullInCSharp_GameConsole
{
    public static class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {


            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or have only withe spaces");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            if (player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine(player.DaysSinceLastLogin.Value);
            }
            else
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }

            if (player.DateOfBirth is null)
            {
                Console.WriteLine("No value for DateOfBirth");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);

            }

            if (player.IsNew is null)
            {
                Console.WriteLine("Player new status is unknown");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is new to the game");
            }
            else
            {
                Console.WriteLine("Player is experienced");

            }

        }
    }
}
