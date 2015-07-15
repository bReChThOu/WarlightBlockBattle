// <copyright file="BlockEngine.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

using System.Collections.Generic;
using System.Linq;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Engine
{
    /// <summary>
    /// The block engine will calculate the possible moves. This is the core of the AI.
    /// </summary>
    public static class BlockEngine
    {
        /// <summary>
        /// Calculates the moves.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <returns></returns>
        public static IEnumerable<MoveType> CalculateMoves(Player player)
        {
            var calculator = new OBlockStrategy();
            return calculator.CalculateMoves(player.CurrentPiece, player.GameField);
        }
    }
}
