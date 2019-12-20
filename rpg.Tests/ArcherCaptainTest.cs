using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Models;
using Xunit;

namespace rpg.Tests
{
    public class ArcherCaptainTest
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void ArcherCaptain_HealthPoints_600()
        {
            ArcherCaptain archer = Creator.CreateArcherCaptain();

            int hp = archer.HealthComponent.HP;

            Assert.Equal(600, hp);
        }

        [Fact]
        public void ArcherCaptain_Damage_30_35()
        {
            ArcherCaptain archer = Creator.CreateArcherCaptain();

            int minDamage = archer.AttackComponent.MinDamage;
            int maxDamage = archer.AttackComponent.MaxDamage;

            Assert.Equal(30, minDamage);
            Assert.Equal(35, maxDamage);
        }

        [Fact]
        public void ArcherCaptain_Armor_1()
        {
            ArcherCaptain archer = Creator.CreateArcherCaptain();

            int armor = archer.ArmorComponent.Armor;

            Assert.Equal(1, armor);
        }

        [Fact]
        public void ArcherCaptain_Mana_200()
        {
            ArcherCaptain archer = Creator.CreateArcherCaptain();

            int mana = archer.ManaComponent.MP;

            Assert.Equal(200, mana);
        }

        [Fact]
        public void ArcherCaptainShot_Damage_150()
        {
            ArcherCaptain archer = Creator.CreateArcherCaptain();

            Shot shot = (Shot)archer.SkillComponent.ActiveSkills[ActiveSkill.SHOT];

            Assert.Equal(150, shot.Damage);
        }

        [Fact]
        public void ArcherCaptainShot_Manacost_50()
        {
            ArcherCaptain archer = Creator.CreateArcherCaptain();

            Shot shot = (Shot)archer.SkillComponent.ActiveSkills[ActiveSkill.SHOT];

            Assert.Equal(50, shot.ManaCost);
        }
    }
}
