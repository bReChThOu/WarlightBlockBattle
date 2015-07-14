// <copyright file="GameSettings.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2014</date>

using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Settings
{
    /// <summary>
    /// Contains all game settings
    /// </summary>
    public class GameSettings
    {
        /// <summary>
        /// Gets or sets the size of the field.
        /// </summary>
        /// <value>
        /// The size of the field.
        /// </value>
        public FieldSize FieldSize { get; set; }

        /// <summary>
        /// Gets or sets the time bank.
        /// </summary>
        /// <value>
        /// The time bank.
        /// </value>
        public int TimeBank { get; set; }

        /// <summary>
        /// Gets or sets the time per move.
        /// </summary>
        /// <value>
        /// The time per move.
        /// </value>
        public int TimePerMove { get; set; }

        /// <summary>
        /// Gets or sets the round number.
        /// </summary>
        /// <value>
        /// The round number.
        /// </value>
        public int RoundNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameSettings"/> class.
        /// </summary>
        public GameSettings()
        {
            FieldSize = new FieldSize();
        }
    }
}
