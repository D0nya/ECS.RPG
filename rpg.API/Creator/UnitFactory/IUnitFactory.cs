using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;

namespace rpg.API.Creator.UnitFactory
{
    public interface IUnitFactory
    {
        IUnit CreateUnit();
    }
}
