using rpg.API.Creator;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Models;
using rpg.Systems.Extentions;
using Xunit;

namespace rpg.Tests
{
    public class SkillsTest
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void ShotManacostAndDamage_ArcherShotOnSwordsman_50mp_402hp()
        {
            Archer archer = Creator.CreateArcher();
            SwordsMan swordsman = Creator.CreateSwordsMan();

            archer.UseSkill(swordsman, ActiveSkill.SHOT);

            Assert.Equal(50, archer.ManaComponent.MP);
            Assert.Equal(402, swordsman.HealthComponent.HP);
        }

        [Fact]
        public void UnitMana_SkillCannotBeApplied_300hp()
        {
            Archer archer = Creator.CreateArcher();
            Archer target = Creator.CreateArcher();
            archer.ManaComponent.MP = 0;

            archer.UseSkill(target, ActiveSkill.SHOT);

            Assert.Equal(300, target.HealthComponent.HP);
        }

        [Fact]
        public void CriticalStrike_MultiplerWorks_150hp()
        {
            Paladin paladin = Creator.CreatePaladin();
            Archer archer = Creator.CreateArcher();
            paladin.AttackComponent.MinDamage = paladin.AttackComponent.MaxDamage = 50;
            ((CriticalStrike)paladin.SkillComponent.PassiveSkills[PassiveSkill.CRITICAL_STRIKE]).Chance = 1;

            paladin.Attack(archer);

            Assert.Equal(150, archer.HealthComponent.HP);
        }
    }
}
