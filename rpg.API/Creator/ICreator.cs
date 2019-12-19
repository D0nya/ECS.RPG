using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator
{
    public interface ICreator
    {
        SwordsMan CreateSwordsMan();
        Archer CreateArcher();
        ArcherCaptain CreateArcherCaptain();
        Skeleton CreateSkeleton();
        Paladin CreatePaladin();
        Mage CreateMage();
    }
}
