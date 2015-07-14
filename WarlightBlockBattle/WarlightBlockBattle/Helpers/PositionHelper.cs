// <copyright file="PositionHelper.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Helpers
{
    public  static class PositionHelper
    {
        /// <summary>
        /// Converts a string to a PiecePosition object
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public static PiecePosition FromString(string position)
        {
            var piecePosition = position.Split(new[] { "," }, 2, StringSplitOptions.RemoveEmptyEntries);
            
            return new PiecePosition
            {
                X = Int32.Parse(piecePosition[0]),
                Y = Int32.Parse(piecePosition[1])
            };
        }
    }
}
