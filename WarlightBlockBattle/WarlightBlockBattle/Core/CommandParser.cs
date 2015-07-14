// <copyright file="CommandParser.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System;
using WarlightBlockBattle.Helpers;
using WarlightBlockBattle.Model;
using WarlightBlockBattle.Settings;

namespace WarlightBlockBattle.Core
{
    public class CommandParser
    {
        /// <summary>
        /// Parses the specified commandline.
        /// </summary>
        /// <param name="commandline">The commandline.</param>
        public void Parse(String commandline)
        {
            if (String.IsNullOrEmpty(commandline))
            {
                return;
            }

            String[] commandargs = commandline.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            if (commandargs.Length == 0)
            {
                return;
            }

            String command = commandargs[0].ToLowerInvariant();
            String subcommand = String.Empty;

            switch (command)
            {
                case "settings":
                    subcommand = commandargs[1].ToLowerInvariant();
                    switch (subcommand)
                    {
                        case "your_bot":
                            String mybotname = commandargs[2];
                            GameSession.Current.SetMyBotName(mybotname);
                            break;
                        case "field_width":
                            int width = Int32.Parse(commandargs[2]);
                            GameSession.Current.SetFieldWidth(width);
                            break;
                        case "field_height":
                            int height = Int32.Parse(commandargs[2]);
                            GameSession.Current.SetFieldHeight(height);
                            break;
                        case "player_names":
                            var playerNames = commandargs[2].Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
                            GameSession.Current.SetPlayers(playerNames);
                            break;
                        case "time_bank":
                            int timeBank = Int32.Parse(commandargs[2]);
                            GameSession.Current.SetTimeBank(timeBank);
                            break;
                        case "time_per_move":
                            int timePerMove = Int32.Parse(commandargs[2]);
                            GameSession.Current.SetTimePerMove(timePerMove);
                            break;
                    }
                    break;
                case "update":
                    subcommand = commandargs[1].Trim().ToLowerInvariant();
                    switch (subcommand)
                    {
                        case "game":
                            var parameter = commandargs[2].Trim().ToLowerInvariant();
                            switch (parameter)
                            {
                                case "round":
                                    int round = Int32.Parse(commandargs[3]);
                                    GameSession.Current.SetRoundNumber(round);
                                    break;
                                case "this_piece_type":
                                    var pieceType = EnumHelper.Parse<PieceType>(commandargs[3]);
                                    GameSession.Current.SetPieceType(pieceType);
                                    break;
                                case "next_piece_type":
                                    var nextPieceType = EnumHelper.Parse<PieceType>(commandargs[3]);
                                    GameSession.Current.SetNextPieceType(nextPieceType);
                                    break;
                                case "this_piece_position":
                                    var piecePosition = PositionHelper.FromString(commandargs[3]);
                                    GameSession.Current.SetPiecePosition(piecePosition);
                                    break;
                            }
                            break;

                        default:
                            var player = subcommand;
                            parameter = commandargs[2].Trim().ToLowerInvariant();
                            switch (parameter)
                            {
                                case "row_points":
                                    int rowPoints = Int32.Parse(commandargs[3]);
                                    GameSession.Current.SetRowPoints(player, rowPoints);
                                    break;
                                case "combo":
                                    int combo = Int32.Parse(commandargs[3]);
                                    GameSession.Current.SetCombo(player, combo);
                                    break;
                                case "field":
                                    var field = FieldHelper.FromString(commandargs[3]);
                                    GameSession.Current.SetField(player, field);
                                    break;
                            }

                            break;
                    }
                    break;
                case "action":
                    CommandBuilder.OutputActions(null);
                    break;
            }
        }
    }
}
