using rpg.Components.Skills.Enums;
using rpg.Systems.Interfaces.Events;

namespace rpg.Systems.Interfaces.SkillStrategy
{
    public interface ISkillStrategy
    {
        SkillEnum Name { get; }
        ISkillEvent SkillEvent { get; set; }
        void Cast();
    }
}
