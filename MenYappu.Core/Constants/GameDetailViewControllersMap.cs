using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenYappu.Core
{
    public static class IdToDetailViewControllersMap
    {
        public static Dictionary<int, string> GameIdToGameDetailViewControllers = new Dictionary<int, string>
        {
            {1, "LetterTypeFinderDetailViewController"},
            {2, "MathiraiCalculatorDetailViewController" }
        };
    }
}
