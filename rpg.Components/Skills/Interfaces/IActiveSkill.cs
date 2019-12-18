namespace rpg.Components.Skills.Interfaces
{
    public interface IActiveSkill : ISkill
    {
        int ManaCost { get; set; }

    }
}
