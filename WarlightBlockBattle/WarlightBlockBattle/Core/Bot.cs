// <copyright file="Bot.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WarlightBlockBattle.Core
{
    /// <summary>
    /// Provides a class that reads and parses the input
    /// </summary>
    public class Bot: IDisposable
    {
        /// <summary>
        /// The parser
        /// </summary>
        private readonly CommandParser _parser;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bot"/> class.
        /// </summary>
        public Bot()
        {
            _parser = new CommandParser();
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        public void Run(bool debug)
        {
            if (debug)
            {
                foreach (var line in File.ReadAllLines(@"output.txt"))
                {
                    _parser.Parse(line);
                }
            }

            while (true)
            {
                /* Normalize the input:
                 * 1) Trim leading and trailing whitespaces
                 * 2) Replace all whitespaces with a regular space
                 * */
                String line = Console.ReadLine().Trim();
                if (!String.IsNullOrEmpty(line))
                {
                    Regex.Replace(line, "\\s+", " ");

                    //Let the parser deal with it
                    _parser.Parse(line);
                }
            }
        }

        public void Dispose()
        {
            
        }
    }
}
