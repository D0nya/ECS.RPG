using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Skills.Models
{
    public class Shot : IActiveSkill
    {
        public SkillEnum Name => SkillEnum.SHOT;
        public int ManaCost { get; set; }
        public int Damage { get; set; }

        public Shot(int manacost, int damage)
        {
            ManaCost = manacost;
            Damage = damage;
        }
    }
}
