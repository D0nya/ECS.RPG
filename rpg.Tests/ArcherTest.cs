using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Models;
using Xunit;

namespace rpg.Tests
{
    public class ArcherTest
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void Archer_HealthPoints_300()
        {
            Archer archer = Creator.CreateArcher();

            int hp = archer.HealthComponent.HP;

            Assert.Equal(300, hp);
        }

        [Fact]
        public void Archer_Damage_15_20()
        {
            Archer archer = Creator.CreateArcher();

            int minDamage = archer.AttackComponent.MinDamage;
            int maxDamage = archer.AttackComponent.MaxDamage;

            Assert.Equal(15, minDamage);
            Assert.Equal(20, maxDamage);
        }

        [Fact]
        public void Archer_Armor_0()
        {
            Archer archer = Creator.CreateArcher();

            int armor = archer.ArmorComponent.Armor;

            Assert.Equal(0, armor);
        }

        [Fact]
        public void Archer_Mana_100()
        {
            Archer archer = Creator.CreateArcher();

            int mana = archer.ManaComponent.MP;

            Assert.Equal(100, mana);
        }

        [Fact]
        public void ArcherShot_Damage_100()
        {
            Archer archer = Creator.CreateArcher();

            Shot shot = (Shot)archer.SkillComponent.ActiveSkills[ActiveSkill.SHOT];

            Assert.Equal(100, shot.Damage);
        }

        [Fact]
        public void ArcherShot_Manacost_50()
        {
            Archer archer = Creator.CreateArcher();

            Shot shot = (Shot)archer.SkillComponent.ActiveSkills[ActiveSkill.SHOT];

            Assert.Equal(50, shot.ManaCost);
        }
    }
}
