using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;
using System;

namespace rpg.Components.Skills.Models
{
    public class CriticalStrike : IPassiveSkill, IAttackModifier
    {
        public PassiveSkill Name => PassiveSkill.CRITICAL_STRIKE;
        public double Chance { get; set; }
        public int Multipler { get; set; }

        public CriticalStrike(double chance, int multipler)
        {
            Chance = chance;
            Multipler = multipler;
        }

        public void Modify(ref int damage)
        {
            Random random = new Random((int)DateTime.Now.ToBinary());
            if(random.Next(0, 100) <= Chance)
            {
                damage *= (1 + Multipler);
                Console.WriteLine("CRIT!");
            }
        }
    }
}
