// <copyright file="CellType.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

namespace WarlightBlockBattle.Model
{
    public enum CellType
    {
        /// <summary>
        /// The cell is empty
        /// </summary>
        Empty,

        /// <summary>
        /// The cell is part of the current moving piece
        /// </summary>
        Shape,

        /// <summary>
        /// The cell is part of a block that can be erased
        /// </summary>
        Block,

        /// <summary>
        /// The cell is solid and cannot be changed again
        /// </summary>
        Solid
    }
}
