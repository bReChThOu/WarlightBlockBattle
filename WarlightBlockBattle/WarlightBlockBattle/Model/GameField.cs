// <copyright file="GameField.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2014</date>

using System.Collections.Generic;
using System.Linq;

namespace WarlightBlockBattle.Model
{
    /// <summary>
    /// Describes a game field
    /// </summary>
    public class GameField
    {
        /// <summary>
        /// Gets or sets the size of the field.
        /// </summary>
        /// <value>
        /// The size of the field.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Gets the field rows.
        /// </summary>
        /// <value>
        /// The field rows.
        /// </value>
        public IEnumerable<FieldRow> FieldRows
        {
            get
            {
                var rows = new List<FieldRow>();

                for (int i = 0; i < Size.Height; i++)
                {
                    rows.Add(new FieldRow
                    {
                        Y = i,
                        RowData = GridData[i]
                    });
                }

                return rows;
            }
        }

        /// <summary>
        /// Gets or sets the grid data.
        /// </summary>
        /// <value>
        /// The grid data.
        /// </value>
        private CellType[][] GridData { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="GameField"/> class.
        /// </summary>
        /// <param name="size">Size of the field.</param>
        public GameField(Size size)
        {
            Size = size;
            InitializeGrid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameField" /> class.
        /// </summary>
        /// <param name="size">Size of the field.</param>
        /// <param name="gridData">The grid data.</param>
        public GameField(Size size, CellType[][] gridData)
        {
            Size = size;
            GridData = gridData;
        }

        /// <summary>
        /// Checks if the space is free.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="startRow">The start row.</param>
        /// <param name="width">The width.</param>
        /// <returns></returns>
        public bool SpaceFree(int x, int startRow, int width)
        {
            for (int y = 0; y <= startRow; y++)
            {
                FieldRows.Single(r => r.Y == y).GetFreePosition(width);
            }

            return true;
        }

        /// <summary>
        /// Initializes the grid.
        /// </summary>
        private void InitializeGrid()
        {
            GridData = new CellType[Size.Height][];

            for (int y = 0; y < Size.Height; y++)
            {
                GridData[y] = new CellType[Size.Width];
            }

            for (int y = 0; y < Size.Height; y++)
            {
                for (int x = 0; x < Size.Width; x++)
                {
                    GridData[y][x] = CellType.Empty;
                }
            }
        }
    }
}
