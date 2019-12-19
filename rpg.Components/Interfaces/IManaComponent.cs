namespace rpg.Components.Interfaces
{
    /// <summary>
    /// Contains unit mana points
    /// </summary>
    public interface IManaComponent : IComponent
    {
        int MP { get; set; }
    }
}
