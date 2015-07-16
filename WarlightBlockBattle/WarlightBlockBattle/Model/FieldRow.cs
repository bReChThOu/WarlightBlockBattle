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

        /// <summary>
        /// Determines whether this instance can host the specified width.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <returns></returns>
        public FreePosition GetFreePosition(int width)
        {
            for (int x = 0; x < Width - width; x++)
            {
                for (int offset = 0; offset < Width - x; offset++)
                {
                    if (RowData[x + offset] != CellType.Empty && RowData[x + offset] != CellType.Shape) // Encountered 
                    {
                        return new FreePosition
                        {
                            UsedAvailableRowSpace = width,
                            TotalAvailableRowSpace = offset,
                            X = x
                        };
                    }
                    else if (offset == Width - x - 1)
                    {
                        return new FreePosition
                        {
                            UsedAvailableRowSpace = width,
                            TotalAvailableRowSpace = offset + 1,
                            X = x
                        };
                    }
                }
            }

            return null;
        }
    }
}
