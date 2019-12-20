using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Entities.Models;
using rpg.Entities.Models.Enums;
using rpg.Systems.Extentions;

namespace rpg.API
{
    class Program
    {
        private static RpgCreator creator;
        static void Main()
        {
            creator = new RpgCreator();
        }
    }
}
