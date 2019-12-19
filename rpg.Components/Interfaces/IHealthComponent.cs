namespace rpg.Components.Interfaces
{
    /// <summary>
    /// Contains unit health points
    /// </summary>
    public interface IHealthComponent : IComponent
    {
        int HP { get; set; }
    }
}
