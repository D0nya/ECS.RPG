using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.Interfaces
{
    /// <summary>
    /// Processes <seealso cref="ISkillAction"/>s
    /// </summary>
    public interface ISkillSystem : ISystem
    {
        ISkillAction SkillAction { get; set; }
    }
}
