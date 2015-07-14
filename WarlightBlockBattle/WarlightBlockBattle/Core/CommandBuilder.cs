// <copyright file="CommandBuilder.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>

// <date>14/07/2015</date>

using System;
using System.Collections.Generic;
using System.Linq;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Core
{
    public class CommandBuilder
    {
        /// <summary>
        /// Outputs the actions.
        /// </summary>
        /// <param name="moves">The moves.</param>
        public static void OutputActions(IEnumerable<MoveType> moves)
        {
            if (moves == null || !moves.Any())
            {
                Output("no_moves");
                return;
            }

            Output(String.Join(",", moves.Select(m => m.ToString().ToLower()).ToArray()));
        }

        /// <summary>
        /// Ouputs the specified line.
        /// </summary>
        /// <param name="line">The line.</param>
        private static void Output(String line)
        {
            Console.WriteLine(line);
        }
    }
}
