// <copyright file="FieldHelper.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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


            // Construct Grid
            var gridData = new CellType[width][];
            for (int x = 0; x < width; x++)
            {
                gridData[x] = new CellType[heigth];
            }

            // Fill Grid
            for (int y = 0; y < rowList.Count; y++)
            {
                for (int x = 0; x < rowList[y].Length; x++)
                {
                    gridData[x][y] = rowList[y][x];
                }
            }

            return new GameField(new FieldSize(width, heigth), gridData);
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
