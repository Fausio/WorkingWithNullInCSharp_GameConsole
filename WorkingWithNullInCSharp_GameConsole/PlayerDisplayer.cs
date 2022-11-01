﻿using System;
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
            Console.WriteLine(player.Name);

            if (player.DaysSinceLastLogin is null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);

            }

            if (player.DateOfBirth is null)
            {
                Console.WriteLine("No value for DateOfBirth");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);

            }

        }
    }
}
