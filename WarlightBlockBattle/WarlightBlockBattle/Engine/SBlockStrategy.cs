// <copyright file="SBlockStrategy.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

using System.Collections.Generic;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Engine
{
    /// <summary>
    /// Strategy for the S Block:
    ///  ##
    /// ##
    /// </summary>
    public class SBlockStrategy : IBlockStrategy
    {
        public IEnumerable<MoveType> CalculateMoves(Piece piece, GameField gameField)
        {
            return null;
        }
    }
}
