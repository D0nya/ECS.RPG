using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Skills.Models
{
    public class CriticalStrike : IPassiveSkill
    {
        public SkillEnum Name => SkillEnum.CRITICAL_STRIKE;
        public double Chance { get; set; }
        public int Multipler { get; set; }

        public CriticalStrike(double chance, int multipler)
        {
            Chance = chance;
            Multipler = multipler;
        }
    }
}
