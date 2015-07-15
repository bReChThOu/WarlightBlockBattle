// <copyright file="Configuration.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>14/07/2015</date>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Settings
{
    public class GameSession
    {
        private static GameSession _instance;

        /// <summary>
        /// The instance
        /// </summary>
        public static GameSession Current
        {
            [DebuggerStepThrough]
            get
            {
                if (_instance == null)
                {
                    _instance = new GameSession();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        private List<Player> Players { get; set; }

        /// <summary>
        /// Gets or sets the game settings.
        /// </summary>
        /// <value>
        /// The game settings.
        /// </value>
        private GameSettings GameSettings { get; set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="GameSession"/> class from being created.
        /// </summary>
        private GameSession()
        {
            Players = new List<Player>();
            GameSettings = new GameSettings();
        }

        /// <summary>
        /// Sets the name of my bot.
        /// </summary>
        /// <param name="botname">The botname.</param>
        public void SetMyBotName(String botname)
        {
            Players.Single(player => player.Name == botname).PlayerType = PlayerType.Me;

        }

        /// <summary>
        /// Sets the width of the field.
        /// </summary>
        /// <param name="width">The width.</param>
        public void SetFieldWidth(int width)
        {
            GameSettings.Size.Width = width;
        }

        /// <summary>
        /// Sets the height of the field.
        /// </summary>
        /// <param name="height">The height.</param>
        public void SetFieldHeight(int height)
        {
            GameSettings.Size.Height = height;
        }

        /// <summary>
        /// Sets the time bank.
        /// </summary>
        /// <param name="timeBank">The time bank.</param>
        public void SetTimeBank(int timeBank)
        {
            GameSettings.TimeBank = timeBank;
        }

        /// <summary>
        /// Sets the time per move.
        /// </summary>
        /// <param name="timePerMove">The time per move.</param>
        public void SetTimePerMove(int timePerMove)
        {
            GameSettings.TimePerMove = timePerMove;
        }

        /// <summary>
        /// Sets the players. All players will be marked as Opponent. Later we will know which player is us and mark it as Me.
        /// </summary>
        /// <param name="players">The players.</param>
        public void SetPlayers(string[] players)
        {
            foreach (var player in players)
            {
                Players.Add(new Player { PlayerType = PlayerType.Opponent, Name = player }); 
            }
        }

        /// <summary>
        /// Sets the round number.
        /// </summary>
        /// <param name="roundNumber">The round number.</param>
        public void SetRoundNumber(int roundNumber)
        {
            GameSettings.RoundNumber = roundNumber;
        }

        /// <summary>
        /// Sets the row points.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="rowPoints">The row points.</param>
        public void SetRowPoints(string player, int rowPoints)
        {
            FindPlayer(player).RowPoints = rowPoints;
        }

        /// <summary>
        /// Sets the combo.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="combo">The combo.</param>
        public void SetCombo(string player, int combo)
        {
            FindPlayer(player).Combo = combo;
        }

        /// <summary>
        /// Sets the gamefield for the given player. 
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="field">The field.</param>
        public void SetField(string player, GameField field)
        {
            FindPlayer(player).GameField = field;
        }

        /// <summary>
        /// Sets the type of the piece.
        /// </summary>
        /// <param name="pieceType">Type of the piece.</param>
        public void SetPieceType(PieceType pieceType)
        {
            FindPlayer().CurrentPieceType = pieceType;
        }

        /// <summary>
        /// Sets the type of the next piece.
        /// </summary>
        /// <param name="pieceType">Type of the piece.</param>
        public void SetNextPieceType(PieceType pieceType)
        {
            FindPlayer().NextPieceType = pieceType;
        }

        /// <summary>
        /// Sets the piece position.
        /// </summary>
        /// <param name="piecePosition">The piece position.</param>
        public void SetPiecePosition(PiecePosition piecePosition)
        {
            FindPlayer().CurrentPiecePosition = piecePosition;
        }

        /// <summary>
        /// Finds the player.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <returns></returns>
        public Player FindPlayer(string player)
        {
            return Players.Single(p => p.Name == player);
        }

        /// <summary>
        /// Finds the player that represents ME.
        /// </summary>
        /// <returns></returns>
        public Player FindPlayer()
        {
            return Players.Single(p => p.PlayerType == PlayerType.Me);
        }

    }
}
