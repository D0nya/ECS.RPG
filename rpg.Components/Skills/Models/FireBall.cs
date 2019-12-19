
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Skills.Models
{
    public class FireBall : IActiveSkill
    {
        public ActiveSkill Name => ActiveSkill.FIREBALL;
        public int ManaCost { get; set; }
        public int Damage { get; set; }

        public FireBall(int manacost, int damage)
        {
            ManaCost = manacost;
            Damage = damage;
        }
    }
}
