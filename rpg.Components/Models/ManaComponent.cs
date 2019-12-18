using rpg.Components.Interfaces;

namespace rpg.Components.Models
{
    public class ManaComponent : IManaComponent
    {
        public int MP { get; set; }
        public ManaComponent(int mp)
        {
            MP = mp;
        }
    }
}
