using rpg.Systems.Interfaces.Events;
using System;

namespace rpg.Systems.Interfaces
{
    public interface ISkillSystem : ISystem
    {
        event Action SkillCasts;
        ISkillEvent SkillEvent { get; set; }
    }
}
