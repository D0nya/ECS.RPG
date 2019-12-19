using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Entities.Models;
using rpg.Entities.Models.Enums;
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
            Paladin p1 = creator.CreatePaladin();
            Mage m1 = creator.CreateMage();

            System.Console.WriteLine(m1);
            System.Console.WriteLine(p1);
            System.Console.WriteLine(sm1);
            m1.UseSkill(p1, ActiveSkill.FIREBALL);
            m1.UseSkill(p1, ActiveSkill.FIREBALL);
            m1.UseSkill(sm1, ActiveSkill.HEAL);
            System.Console.WriteLine(p1);
            System.Console.WriteLine(sm1);
        }
    }
}
