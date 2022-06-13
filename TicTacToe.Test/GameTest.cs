using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Business.Entities;
using TicTacToe.Business.Interface;

namespace TicTacToe.Test
{
    [TestClass]
    public class GameTest
    {
        Business.TicTacToe ticTacToe = new Business.TicTacToe();

        [TestMethod]
        public void CheckWinner_ShouldReturnWinner()
        {
            var position = new List<Position>();
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });

            var result = ticTacToe.Play(position);

            Assert.IsTrue(result.Winner);
        }

        [TestMethod]
        public void CheckWinner_ShouldReturnNoWinner()
        {
            var position = new List<Position>();
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });

            var result = ticTacToe.Play(position);

            Assert.IsFalse(result.Winner);
        }

        [TestMethod]
        public void CheckWinner_ShouldReturnPlayerXWinner()
        {
            var position = new List<Position>();
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });

            var result = ticTacToe.Play(position);

            Assert.AreEqual(result.PlayerName, "X");
        }

        [TestMethod]
        public void CheckWinner_ShouldReturnPlayerOWinner()
        {
            var position = new List<Position>();
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });
            position.Add(new Position() { Player = "" });

            var result = ticTacToe.Play(position);

            Assert.AreEqual(result.PlayerName, "O");
        }

        [TestMethod]
        public void CheckWinner_ShouldReturnDraw()
        {
            var position = new List<Position>();
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "X" });
            position.Add(new Position() { Player = "O" });
            position.Add(new Position() { Player = "X" });

            var result = ticTacToe.Play(position);

            Assert.AreEqual(result.PlayerName, "draw");
        }
    }
}
