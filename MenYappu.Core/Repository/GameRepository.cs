using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenYappu.Core;

namespace MenYappu.Core
{
    public class GameRepository
    {
        public GameRepository()
        {

        }

        private static readonly List<Game> Games = new List<Game>
        {
            new Game
            {
                GameId = 1,
                Name = "எழுத்து வகைபிரி",
                Description =
                    "ஒரு சொல்லிலுள்ள எழுத்துகளின் வகைகளைப் பிரித்து அவை சரியா தவறா எனப் பார்க்கும் விளையாட்டு.",
                Instructions = "ஒரேயொரு சொல்லை மட்டும் உள்ளிடவும் (அ) கீழேயுள்ள “மாதிரி” பொத்தானை அழுத்தவும்.",
                HelpPage = "LetterTypeFinder"
            },
            new Game
            {
                GameId = 2,
                Name = "மாத்திரை எவ்வளவு?",
                Description =
                    "ஒரு சொல்லிலுள்ள எழுத்துகளை உச்சரிப்பதற்கு ஆகும் கால அளவைக் கணக்கிடுப் பார்க்கும் விளையாட்டு.",
                Instructions = "ஒரெயொரு சொல்லை (அ) வாக்கியத்தை உள்ளிடவும் (அ) கீழேயுள்ள “மாதிரி” பொத்தானை அழுத்தவும்.",
                HelpPage = "MathiraiCalculator"
            }
        };

        public List<Game> GetAllGames()
        {
            return Games;
        }
    }
}
