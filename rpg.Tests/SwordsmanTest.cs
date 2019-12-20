using rpg.API.Creator;
using rpg.Entities.Models;
using Xunit;

namespace rpg.Tests
{
    public class SwordsmanTest
    {
        public RpgCreator Creator { get; set; } = new RpgCreator();

        [Fact]
        public void Swordsman_HealthPoints_500()
        {
            SwordsMan swordsman = Creator.CreateSwordsMan();

            int hp = swordsman.HealthComponent.HP;

            Assert.Equal(500, hp);
        }

        [Fact]
        public void Swordsman_Damage_20_30()
        {
            SwordsMan swordsman = Creator.CreateSwordsMan();

            int minDamage = swordsman.AttackComponent.MinDamage;
            int maxDamage = swordsman.AttackComponent.MaxDamage;

            Assert.Equal(20, minDamage);
            Assert.Equal(30, maxDamage);
        }

        [Fact]
        public void Swordsman_Armor_2()
        {
            SwordsMan swordsman = Creator.CreateSwordsMan();

            int armor = swordsman.ArmorComponent.Armor;

            Assert.Equal(2, armor);
        }

        [Fact]
        public void Swordsman_Mana_0()
        {
            SwordsMan swordsman = Creator.CreateSwordsMan();

            int mana = swordsman.ManaComponent.MP;

            Assert.Equal(0, mana);
        }

    }
}
