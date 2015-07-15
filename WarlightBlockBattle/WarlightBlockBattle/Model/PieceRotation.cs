// <copyright file="PieceRotation.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

namespace WarlightBlockBattle.Model
{
    public enum PieceRotation
    {
        /// <summary>
        /// The piece is rotated up (Default)
        /// </summary>
        Default,

        /// <summary>
        /// The piece is rotated down (180 degrees rotated)
        /// </summary>
        Down,

        /// <summary>
        /// The piece is rotated 90 degrees counter clockwise
        /// </summary>
        Left,

        /// <summary>
        /// The piece is rotated 90 degrees clockwise
        /// </summary>
        Right
    }
}
