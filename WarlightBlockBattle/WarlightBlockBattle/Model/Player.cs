// <copyright file="Player.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

namespace WarlightBlockBattle.Model
{
    /// <summary>
    /// Defines a Player
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the row points.
        /// </summary>
        /// <value>
        /// The row points.
        /// </value>
        public int RowPoints { get; set; }

        /// <summary>
        /// Gets or sets the combo.
        /// </summary>
        /// <value>
        /// The combo.
        /// </value>
        public int Combo { get; set; }

        /// <summary>
        /// Gets or sets the game field.
        /// </summary>
        /// <value>
        /// The game field.
        /// </value>
        public GameField GameField { get; set; }

        /// <summary>
        /// Gets or sets the type of the player.
        /// </summary>
        /// <value>
        /// The type of the player.
        /// </value>
        public PlayerType PlayerType { get; set; }

        /// <summary>
        /// Gets or sets the current piece.
        /// </summary>
        /// <value>
        /// The current piece.
        /// </value>
        public PieceType CurrentPiece { get; set; }

        /// <summary>
        /// Gets or sets the current piece position.
        /// </summary>
        /// <value>
        /// The current piece position.
        /// </value>
        public PiecePosition CurrentPiecePosition { get; set; }

        /// <summary>
        /// Gets or sets the next piece.
        /// </summary>
        /// <value>
        /// The next piece.
        /// </value>
        public PieceType NextPiece { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return PlayerType.ToString();
        }
    }
}
