// <copyright file="BlockEngine.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

using System;
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
			var calculator = GetCalculator(player.CurrentPiece);
            return calculator.CalculateMoves(player.CurrentPiece, player.GameField);
        }

		private static IBlockStrategy GetCalculator(Piece piece)
		{
			switch (piece.Type.TypeLetter)
			{
				default:
				case "O":
					return new OBlockStrategy();
				case "S":
					return new SBlockStrategy();
				case "T":
					return new TBlockStrategy();
				case "Z":
					return new ZBlockStrategy();
				case "I":
					return new IBlockStrategy();
				case "J":
					return new JBlockStrategy();
				case "L":
					return new LBlockStrategy();
			}
		}
    }
}
