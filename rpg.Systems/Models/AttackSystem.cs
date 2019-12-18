using System;
using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces;
using rpg.Systems.Interfaces.Events;

namespace rpg.Systems.Models
{
    public class AttackSystem : IAttackSystem
    {
        public event Action AttackPerformes;
        public IAttackEvent AttackEvent { get; set; }

        public AttackSystem(IAttackEvent attackEvent)
        {
            AttackEvent = attackEvent;
        }
        public void Execute()
        {
            if(AttackPerformes != null)
                AttackPerformes.Invoke();
            AttackAction();
        }

        private void AttackAction()
        {
            IUnit target = AttackEvent.Target;
            IAttackComponent attack = AttackEvent.Attack;
            Random random = new Random((int)DateTime.Now.ToBinary());

            int damage = random.Next(attack.MinDamage, attack.MaxDamage);
            int armor = target.ArmorComponent.Armor;
            int finalDamage = damage - armor;

            target.HealthComponent.HP -= finalDamage;
        }
    }
}
