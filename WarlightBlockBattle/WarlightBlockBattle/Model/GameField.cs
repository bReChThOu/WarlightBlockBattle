// <copyright file="GameField.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2014</date>

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
        public FieldSize FieldSize { get; set; }

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
        /// <param name="fieldSize">Size of the field.</param>
        public GameField(FieldSize fieldSize)
        {
            FieldSize = fieldSize;
            InitializeGrid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameField" /> class.
        /// </summary>
        /// <param name="fieldSize">Size of the field.</param>
        /// <param name="gridData">The grid data.</param>
        public GameField(FieldSize fieldSize, CellType[][] gridData)
        {
            FieldSize = fieldSize;
            GridData = gridData;
        }

        /// <summary>
        /// Initializes the grid.
        /// </summary>
        private void InitializeGrid()
        {
            GridData = new CellType[FieldSize.Width][];

            for (int x = 0; x < FieldSize.Width; x++)
            {
                GridData[x] = new CellType[FieldSize.Height];
            }

            for (int x = 0; x < FieldSize.Width; x++)
            {
                for (int y = 0; y < FieldSize.Height; y++)
                {
                    GridData[x][y] = CellType.Empty;
                }
            }
        }
    }
}
