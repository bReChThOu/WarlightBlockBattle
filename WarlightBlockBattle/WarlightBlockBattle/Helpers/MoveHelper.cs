// <copyright file="MoveHelper.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>16/07/2015</date>

using System.Collections.Generic;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Helpers
{
    public static class MoveHelper
    {
        /// <summary>
        /// Creates a list of Moves to move the block to the given location on the field.
        /// </summary>
        /// <param name="piece">The piece.</param>
        /// <param name="x">The x-coordinate.</param>
        /// <returns></returns>
        public static IEnumerable<MoveType> MoveTo(Piece piece, int x)
        {
            var moves = new List<MoveType>();
            if (piece.Position.X > x)
            {
                for (int delta = 0; delta < piece.Position.X - x; delta++)
                {
                    moves.Add(MoveType.Left);
                }
            }

            if (piece.Position.X < x)
            {
                for (int delta = 0; delta < x - piece.Position.X; delta++)
                {
                    moves.Add(MoveType.Right);
                }
            }

            return moves;
        }
    }
}
