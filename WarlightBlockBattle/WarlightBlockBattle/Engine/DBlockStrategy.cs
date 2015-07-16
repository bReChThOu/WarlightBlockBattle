// <copyright file="DBlockStrategy.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>16/07/2015</date>

using System.Collections.Generic;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Engine
{
    /// <summary>
    /// Strategy for the I Block:
    /// ####
    /// </summary>
    public class DBlockStrategy : IBlockStrategy
    {
        /// <summary>
        /// Try to clear a line. Of no line can be cleared, drop it on the lowest possible row and turn it of required
        /// </summary>
        /// <param name="piece">The piece.</param>
        /// <param name="gameField">The game field.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<MoveType> CalculateMoves(Piece piece, GameField gameField)
        {
            return null;
        }
    }
}
