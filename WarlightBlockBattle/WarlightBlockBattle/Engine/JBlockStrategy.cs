// <copyright file="JBlockStrategy.cs">
//        Copyright (c) 2015 All Rights Reserved
// </copyright>
// <author>Brecht Houben</author>
// <date>15/07/2015</date>

using System.Collections.Generic;
using System.Linq;
using WarlightBlockBattle.Helpers;
using WarlightBlockBattle.Model;

namespace WarlightBlockBattle.Engine
{
	/// <summary>
	/// Strategy for the J Block:
	///  #
	///  ###
	/// </summary>
	public class JBlockStrategy : IBlockStrategy
	{
	    public IEnumerable<MoveType> CalculateMoves(Piece piece, GameField gameField)
	    {
            var moves = new List<MoveType>();

            foreach (var row in gameField.FieldRows.OrderByDescending(r => r.Y))
            {
                var freePosition = row.GetFreePosition(piece.GetWidth());
                if (freePosition == null)
                {
                    continue;
                }

                if (freePosition.TotalAvailableRowSpace == 3) // Drop block in this gap - we can clear a line
                {
                    if (gameField.SpaceFree(freePosition.X, row.Y - 1, piece.GetWidth()))
                    {
                        moves.AddRange(MoveHelper.MoveTo(piece, freePosition.X));
                        break;
                    }
                }

                if (freePosition.TotalAvailableRowSpace == 2) // Rotate and then drop block in this gap - we can clear a line
                {
                    piece.Rotation = PieceRotation.Left;
                    moves.Add(MoveType.TurnLeft);

                    if (gameField.SpaceFree(freePosition.X, row.Y - 1, piece.GetWidth()))
                    {
                        moves.AddRange(MoveHelper.MoveTo(piece, freePosition.X));
                        break;
                    }
                }

                if (freePosition.TotalAvailableRowSpace >= 4)
                {
                    piece.Rotation = PieceRotation.Left;
                    moves.Add(MoveType.TurnLeft);

                    if (gameField.SpaceFree(freePosition.X, row.Y - 1, piece.GetWidth()))
                    {
                        moves.AddRange(MoveHelper.MoveTo(piece, freePosition.X));
                        break;
                    }
                }
            }

            return moves;
	    }
	}
}
