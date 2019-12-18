using rpg.Components.Interfaces;

namespace rpg.Components.Models
{
    public class ArmorComponent : IArmorComponent
    {
        public int Armor { get; set; }
        public ArmorComponent(int armor)
        {
            Armor = armor;
        }
    }
}
