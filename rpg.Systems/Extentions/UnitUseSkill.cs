using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces;
using rpg.Systems.Interfaces.Events;
using rpg.Systems.Models;
using rpg.Systems.Models.Events;

namespace rpg.Systems.Extentions
{
    public static class UnitUseSkill
    {
        public static void UseSkill(this IUnit source, IUnit target, SkillEnum skill)
        {
            ISkill selected =  source.SkillComponent.Skills[skill];
            if (selected is IPassiveSkill)
            {
                System.Console.WriteLine("Cant cast passive skills");
                return;
            }
            if(((IActiveSkill)selected).ManaCost > source.ManaComponent.MP)
            {
                System.Console.WriteLine("Not enough mana");
                return;
            }

            ISkillEvent skillEvent = new SkillEvent(source.SkillComponent, target, skill);
            ISkillSystem skillSystem = new SkillSystem(skillEvent);
            skillSystem.Execute();
            source.ManaComponent.MP -= ((IActiveSkill)selected).ManaCost;
        }
    }
}
