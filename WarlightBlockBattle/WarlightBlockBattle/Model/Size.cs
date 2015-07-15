// <copyright file="FieldSize.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

namespace WarlightBlockBattle.Model
{
    /// <summary>
    /// Describes the size of the field
    /// </summary>
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class.
        /// </summary>
        public Size()
        {
            
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="heigth">The heigth.</param>
        public Size(int width, int heigth)
        {
            Width = width;
            Height = heigth;
        }
    }
}
