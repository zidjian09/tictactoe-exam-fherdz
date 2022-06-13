using System;
using System.Collections.Generic;
using TicTacToe.Business.Entities;
using TicTacToe.Business.Interface;

namespace TicTacToe.Business
{
    public class TicTacToe : IGame
    {
        private readonly int[,] _winningCombinations = {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        private Player player = new Player();
        public Player Play(List<Position> playerPositions)
        {
            return CheckWinner(playerPositions);
        }

        private Player CheckWinner(List<Position> playerPositions)
        {
            if (IsDrawGame(playerPositions))
            {
                return new Player
                {
                    Winner = false,
                    PlayerName = "draw"
                };
            }
            for (var i = 0; i < 8; i++)
            {
                int a = _winningCombinations[i, 0], b = _winningCombinations[i, 1], c = _winningCombinations[i, 2]; 

                if (playerPositions[a].Player == "" || playerPositions[b].Player == "" || playerPositions[c].Player == "")  
                    continue;

                if (playerPositions[a].Player == playerPositions[b].Player && playerPositions[b].Player == playerPositions[c].Player) 
                {
                    player = new Player
                    {
                        Winner = true,
                        PlayerName = playerPositions[a].Player
                    };

                    return player;
                }

            }
            return new Player
            {
                Winner = false,
                PlayerName = ""
            };
        }

        private bool IsDrawGame(List<Position> playerPositions)
        {
            foreach (var pp in playerPositions)
            {
                if (pp.Player != "X" && pp.Player != "O") return false;
            }

            return true;
        }
    }
}
