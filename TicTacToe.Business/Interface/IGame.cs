using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Business.Entities;

namespace TicTacToe.Business.Interface
{
    public interface IGame
    {
        Player Play(List<Position> playerPositions);
    }
}
