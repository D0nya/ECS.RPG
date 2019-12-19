using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;
using rpg.Systems.Manager;
using rpg.Systems.Models.Actions;

namespace rpg.Systems.Extentions
{
    public static class UnitAttack
    {
        /// <summary>
        /// Creates and processes attack action
        /// </summary>
        /// <param name="attacker">Unit which attacks</param>
        /// <param name="target">Unit attacked</param>
        public static void Attack(this IUnit attacker, IUnit target)
        {
            IAttackAction attackAction = new AttackAction(attacker, target);
            SystemHandler.Execute(attackAction);
        }
    }
}
