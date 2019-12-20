using rpg.API.Creator;
using rpg.Entities.Models;
using rpg.Systems.Extentions;
using Xunit;

namespace rpg.Tests
{
    public class UnitsTest
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void Unit_IsDead_True()
        {
            Archer archer = Creator.CreateArcher();
            archer.HealthComponent.HP = 0;

            bool isDead = archer.IsDead;

            Assert.True(isDead);
        }

        [Fact]
        public void UnitArmor_CastShotOnSwordsman_402hp()
        {
            Archer archer = Creator.CreateArcher();
            SwordsMan swordsman = Creator.CreateSwordsMan();

            archer.UseSkill(swordsman, Components.Skills.Enums.ActiveSkill.SHOT);

            Assert.Equal(402, swordsman.HealthComponent.HP);
        }
    }
}
