﻿using rpg.Components.Interfaces;
using rpg.Entities.Models.Enums;

namespace rpg.Entities.Models
{
    public class ArcherCaptain : Unit
    {
        public ArcherCaptain(int id, IAttackComponent attackComponent, 
                                     IHealthComponent healthComponent, 
                                     IManaComponent manaComponent, 
                                     IArmorComponent armorComponent, 
                                     ISkillComponent skillComponent) 
            : base(id, attackComponent, healthComponent, manaComponent, armorComponent, skillComponent)
        {
        }

        public override Units Name => Units.Archer_Captain;

    }
}
