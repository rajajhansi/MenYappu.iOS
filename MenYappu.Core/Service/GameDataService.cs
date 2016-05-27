using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenYappu.Core;

namespace MenYappu.Core
{
    public class GameDataService
    {
        private static GameRepository gameRepository = new GameRepository();

        public GameDataService()
        {

        }

        public List<Game> GetAllGames()
        {
            return gameRepository.GetAllGames();
        }
    }
}
