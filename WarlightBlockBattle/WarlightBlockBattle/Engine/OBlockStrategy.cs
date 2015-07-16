// <copyright file="OBlockStrategy.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

using System.Collections.Generic;
using System.Linq;
using WarlightBlockBattle.Helpers;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Engine
{
    /// <summary>
    /// Strategy for the O Block:
    /// ##
    /// ##
    /// </summary>
    public class OBlockStrategy : IBlockStrategy
    {
        /// <summary>
        /// Calculates the moves.
        /// </summary>
        /// <param name="piece">The piece.</param>
        /// <param name="gameField">The game field.</param>
        /// <returns></returns>
        public IEnumerable<MoveType> CalculateMoves(Piece piece, GameField gameField)
        {
            var moves = new List<MoveType>();

            foreach (var row in gameField.FieldRows.OrderByDescending(r => r.Y))
            {
                var freePosition = row.GetFreePosition(piece.GetWidth());
                if (freePosition != null && freePosition.TotalAvailableRowSpace != 3)
                {
                    if (gameField.SpaceFree(freePosition.X, row.Y - 1, piece.GetWidth()))
                    {
                        moves.AddRange(MoveHelper.MoveTo(piece, freePosition.X));
                        break;
                    }
                }
            }

            return moves;
        }
    }
}
