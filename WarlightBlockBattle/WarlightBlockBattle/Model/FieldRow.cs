// <copyright file="Player.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System.Linq;

namespace WarlightBlockBattle.Model
{
    public class FieldRow
    {
        /// <summary>
        /// Gets or sets the y position of the row.
        /// </summary>
        /// <value>
        /// The y position of the row.
        /// </value>
        public int Y { get; set; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width
        {
            get
            {
                if (RowData.Any())
                {
                    return RowData.Count();
                }

                return 0;
            }
        }

        /// <summary>
        /// Gets or sets the row data.
        /// </summary>
        /// <value>
        /// The row data.
        /// </value>
        public CellType[] RowData { get; set; }
    }
}
