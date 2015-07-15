// <copyright file="FieldHelper.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System;
using System.Collections.Generic;
using System.Linq;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Helpers
{
    public static class FieldHelper
    {
        /// <summary>
        /// Creates a GameField object from the given string
        /// </summary>
        /// <param name="fieldData">The field data.</param>
        /// <returns></returns>
        public static GameField FromString(string fieldData)
        {
            var rows = fieldData.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries);
            var rowList = new List<CellType[]>();

            foreach (var row in rows)
            {
                var rowData = row
                    .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(ToCellType)
                    .ToArray();

                rowList.Add(rowData);
            }

            int width = rowList.First().Length;
            int heigth = rows.Length;


            // Construct and Initialize Grid
            var gridData = new CellType[heigth][];
            for (int y = 0; y < heigth; y++)
            {
                gridData[y] = new CellType[width];
                for (int x = 0; x < width; x++)
                {
                    gridData[y][x] = CellType.Empty;
                }
            }

            return new GameField(new Size(width, heigth), gridData);
        }

        /// <summary>
        /// Converts a string to CellType
        /// </summary>
        /// <param name="cellType">Type of the cell.</param>
        /// <returns></returns>
        public static CellType ToCellType(string cellType)
        {
            switch (cellType)
            {
                case "0":
                    return CellType.Empty;
                case "1":
                    return CellType.Shape;
                case "2":
                    return CellType.Block;
                case "3":
                    return CellType.Solid;
                default:
                    return CellType.Empty;
                    ;
            }
        }
    }
}
