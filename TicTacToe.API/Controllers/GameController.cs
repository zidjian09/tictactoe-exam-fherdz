using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicTacToe.Business.Entities;
using TicTacToe.Business.Interface;
using System.Web.Http.Cors;

namespace TicTacToe.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GameController : ApiController
    {
        private readonly IGame _iGame;
        public GameController(IGame iGame)
        {
            _iGame = iGame;
        }

        // POST api/values
        public Player Post([FromBody] List<Position> positions)
        {
            return _iGame.Play(positions);
        }
    }
}
