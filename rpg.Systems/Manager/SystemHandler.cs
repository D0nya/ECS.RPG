using rpg.Systems.Interfaces;
using rpg.Systems.Interfaces.Actions;
using rpg.Systems.Models;

namespace rpg.Systems.Manager
{
    /// <summary>
    /// Handles choise of concrete System 
    /// <para><seealso cref="ISystem"/></para>
    /// </summary>
    public static class SystemHandler
    {
        public static IAttackSystem AttackSystem { get; set; }
        public static ISkillSystem SkillSystem { get; set; }

        static SystemHandler()
        {
            AttackSystem = new AttackSystem();
            SkillSystem = new SkillSystem();
        }

        public static void Execute(IAttackAction evnt)
        {
            AttackSystem.AttackAction = evnt;
            AttackSystem.Execute();
        }

        public static void Execute(ISkillAction evnt)
        {
            SkillSystem.SkillAction = evnt;
            SkillSystem.Execute();
        }
    }
}
