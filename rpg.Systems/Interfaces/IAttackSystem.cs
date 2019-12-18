using rpg.Systems.Interfaces.Events;
using System;

namespace rpg.Systems.Interfaces
{
    public interface IAttackSystem : ISystem
    {
        event Action AttackPerformes;
        IAttackEvent AttackEvent { get; set; }

    }
}
