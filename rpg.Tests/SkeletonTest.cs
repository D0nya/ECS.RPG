using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Models;
using Xunit;

namespace rpg.Tests
{
    public class SkeletonTest
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void Skeleton_HealthPoints_180()
        {
            Skeleton skeleton = Creator.CreateSkeleton();

            int hp = skeleton.HealthComponent.HP;

            Assert.Equal(180, hp);
        }

        [Fact]
        public void Skeleton_Damage_5_8()
        {
            Skeleton skeleton = Creator.CreateSkeleton();

            int minDamage = skeleton.AttackComponent.MinDamage;
            int maxDamage = skeleton.AttackComponent.MaxDamage;

            Assert.Equal(5, minDamage);
            Assert.Equal(8, maxDamage);
        }

        [Fact]
        public void Skeleton_Armor_1()
        {
            Skeleton skeleton = Creator.CreateSkeleton();

            int armor = skeleton.ArmorComponent.Armor;

            Assert.Equal(1, armor);
        }

        [Fact]
        public void Skeleton_Mana_0()
        {
            Skeleton skeleton = Creator.CreateSkeleton();

            int mana = skeleton.ManaComponent.MP;

            Assert.Equal(0, mana);
        }

        [Fact]
        public void SkeletonCriticalStrike_Chance_20()
        {
            Skeleton skeleton = Creator.CreateSkeleton();

            CriticalStrike cs = (CriticalStrike)skeleton.SkillComponent.PassiveSkills[PassiveSkill.CRITICAL_STRIKE];

            Assert.Equal(0.2, cs.Chance);
        }

        [Fact]
        public void SkeletonCriticalStrike_Multipler_2()
        {
            Skeleton skeleton = Creator.CreateSkeleton();

            CriticalStrike cs = (CriticalStrike)skeleton.SkillComponent.PassiveSkills[PassiveSkill.CRITICAL_STRIKE];

            Assert.Equal(2, cs.Multipler);
        }
    }
}
