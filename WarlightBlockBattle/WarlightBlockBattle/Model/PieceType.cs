﻿// <copyright file="PieceType.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

namespace WarlightBlockBattle.Model
{
    /// <summary>
    /// Describes all piece types
    /// </summary>
    public class PieceType
    {
        /// <summary>
        /// Gets or sets the size of the box.
        /// </summary>
        /// <value>
        /// The size of the box.
        /// </value>
        public Size BoxSize { get; set; }

        /// <summary>
        /// Gets or sets the type letter.
        /// </summary>
        /// <value>
        /// The type letter.
        /// </value>
        public string TypeLetter { get; set; }


        public static PieceType I = new PieceType
        {
            TypeLetter = "I",
            BoxSize = new Size(4, 4)
        };

        public static PieceType J = new PieceType
        {
            TypeLetter = "J",
            BoxSize = new Size(3, 3)
        };

        public static PieceType L = new PieceType
        {
            TypeLetter = "L",
            BoxSize = new Size(3, 3)
        };

        public static PieceType O = new PieceType
        {
            TypeLetter = "O",
            BoxSize = new Size(2, 2)
        };

        public static PieceType S = new PieceType
        {
            TypeLetter = "S",
            BoxSize = new Size(3, 3)
        };

        public static PieceType T = new PieceType
        {
            TypeLetter = "T",
            BoxSize = new Size(3, 3)
        };

        public static PieceType Z = new PieceType
        {
            TypeLetter = "Z",
            BoxSize = new Size(3, 3)
        };

        /// <summary>
        /// Returns the piece type based on its string representation
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PieceType FromString(string value)
        {
            switch (value)
            {
                default:
                case "I":
                    return I;
                case "J":
                    return J;
                case "L":
                    return L;
                case "O":
                    return O;
                case "S":
                    return S;
                case "T":
                    return T;
                case "Z":
                    return Z;
            }
        }
    }
}
