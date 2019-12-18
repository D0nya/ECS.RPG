using rpg.Components.Interfaces;

namespace rpg.Components.Models
{
    public class HealthComponent : IHealthComponent
    {
        public int HP { get; set; }
        public HealthComponent(int hp)
        {
            HP = hp;
        }
    }
}
