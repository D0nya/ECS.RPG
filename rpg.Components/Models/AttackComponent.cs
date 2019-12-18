using rpg.Components.Interfaces;

namespace rpg.Components.Models
{
    public class AttackComponent : IAttackComponent
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public AttackComponent(int minDmg, int maxDmg)
        {
            MinDamage = minDmg;
            MaxDamage = maxDmg;
        }
    }
}
