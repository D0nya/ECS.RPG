using System.Collections.Generic;
using rpg.Components.Interfaces;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Models
{
    public class AttackComponent : IAttackComponent
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public IEnumerable<IAttackModifier> Modifiers { get; set; }

        public AttackComponent(int minDmg, int maxDmg)
        {
            MinDamage = minDmg;
            MaxDamage = maxDmg;
        }
    }
}
