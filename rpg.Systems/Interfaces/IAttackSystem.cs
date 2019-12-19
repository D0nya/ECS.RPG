using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.Interfaces
{
    /// <summary>
    /// Processes <seealso cref="IAttackAction"/>s
    /// </summary>
    public interface IAttackSystem : ISystem
    {
        IAttackAction AttackAction { get; set; }
    }
}
