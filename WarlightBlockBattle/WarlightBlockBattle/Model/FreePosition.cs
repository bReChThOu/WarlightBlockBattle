// <copyright file="FreePosition.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>16/07/2015</date>

namespace WarlightBlockBattle.Model
{
    /// <summary>
    /// Describes the free spaces on the field row
    /// </summary>
    public class FreePosition
    {
        /// <summary>
        /// Gets or sets the total available row space.
        /// </summary>
        /// <value>
        /// The total available row space.
        /// </value>
        public int TotalAvailableRowSpace { get; set; }

        /// <summary>
        /// Gets or sets the used available row space.
        /// </summary>
        /// <value>
        /// The used available row space.
        /// </value>
        public int UsedAvailableRowSpace { get; set; }

        /// <summary>
        /// Gets or sets the x-coordinate where the space starts.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        public int X { get; set; }
    }
}
