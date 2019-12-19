using System;
using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces;
using rpg.Components.Skills.Interfaces;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.Models
{
    public class AttackSystem : IAttackSystem
    {
        public IAttackAction AttackAction { get; set; }

        public AttackSystem()
        {
        }

        public AttackSystem(IAttackAction attackAction)
        {
            AttackAction = attackAction;
        }

        public void Execute()
        {
            Attack();
        }

        /// <summary>
        /// Logic of attack
        /// </summary>
        private void Attack()
        {
            IUnit target = AttackAction.Target;
            IUnit attacker = AttackAction.Attacker;
            Random random = new Random((int)DateTime.Now.ToBinary());


            int damage = random.Next(attacker.AttackComponent.MinDamage, attacker.AttackComponent.MaxDamage);
            foreach (IAttackModifier modifier in attacker.AttackComponent.Modifiers)
            {
                modifier.Modify(ref damage);
            }

            int armor = target.ArmorComponent.Armor;
            int finalDamage = damage - armor;
            Console.WriteLine(target.Name + " gets " + damage + " damage");

            target.HealthComponent.HP -= finalDamage;
        }
    }
}
