using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Skills.Models
{
    public class Heal : IActiveSkill
    {
        public ActiveSkill Name => ActiveSkill.HEAL;
        public int ManaCost { get; set; }
        public int HealAmount { get; set; }

        public Heal(int manacost, int healAmount)
        {
            ManaCost = manacost;
            HealAmount = healAmount;
        }
    }
}
