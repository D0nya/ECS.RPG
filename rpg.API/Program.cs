using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Entities.Models;
using rpg.Systems.Extentions;

namespace rpg.API
{
    class Program
    {
        private static ICreator creator;
        static void Main()
        {
            creator = new RpgCreator();

            SwordsMan sm1 = creator.CreateSwordsMan();
            Archer ac1 = creator.CreateArcher();
            Skeleton sk1 = creator.CreateSkeleton();

            ac1.UseSkill(sm1, SkillEnum.SHOT);

            System.Console.WriteLine(sm1);
        }
    }
}
