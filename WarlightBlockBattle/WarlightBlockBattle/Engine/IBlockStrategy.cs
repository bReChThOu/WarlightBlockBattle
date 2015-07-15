// <copyright file="IBlockStrategy.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

using System.Collections.Generic;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Engine
{
    public interface IBlockStrategy
    {
        IEnumerable<MoveType> CalculateMoves(Piece piece, GameField gameField);
    }
}
