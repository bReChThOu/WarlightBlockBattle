// <copyright file="Piece.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

namespace WarlightBlockBattle.Model
{
    public class Piece
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public PiecePosition Position { get; set; }

        /// <summary>
        /// Gets or sets the type of the piece.
        /// </summary>
        /// <value>
        /// The type of the piece.
        /// </value>
        public PieceType Type { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        /// <value>
        /// The rotation.
        /// </value>
        public PieceRotation Rotation { get; set; }
    }
}
