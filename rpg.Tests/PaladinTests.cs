using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Models;
using Xunit;

namespace rpg.Tests
{
    public class PaladinTests
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void Paladin_HealthPoints_700()
        {
            Paladin archer = Creator.CreatePaladin();

            int hp = archer.HealthComponent.HP;

            Assert.Equal(700, hp);
        }

        [Fact]
        public void Paladin_Damage_40_50()
        {
            Paladin paladin = Creator.CreatePaladin();

            int minDamage = paladin.AttackComponent.MinDamage;
            int maxDamage = paladin.AttackComponent.MaxDamage;

            Assert.Equal(40, minDamage);
            Assert.Equal(50, maxDamage);
        }

        [Fact]
        public void Paladin_Armor_5()
        {
            Paladin paladin = Creator.CreatePaladin();

            int armor = paladin.ArmorComponent.Armor;

            Assert.Equal(5, armor);
        }

        [Fact]
        public void Paladin_Mana_300()
        {
            Paladin paladin = Creator.CreatePaladin();

            int mana = paladin.ManaComponent.MP;

            Assert.Equal(300, mana);
        }

        [Fact]
        public void PaladinCriticalStrike_Chance_30()
        {
            Paladin paladin = Creator.CreatePaladin();

            CriticalStrike cs = (CriticalStrike)paladin.SkillComponent.PassiveSkills[PassiveSkill.CRITICAL_STRIKE];

            Assert.Equal(0.3, cs.Chance);
        }

        [Fact]
        public void PaladinCriticalStrike_Multipler_3()
        {
            Paladin paladin = Creator.CreatePaladin();

            CriticalStrike cs = (CriticalStrike)paladin.SkillComponent.PassiveSkills[PassiveSkill.CRITICAL_STRIKE];

            Assert.Equal(3, cs.Multipler);
        }
    }
}
