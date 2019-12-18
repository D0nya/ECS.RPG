using rpg.API.Creator.UnitFactory;
using rpg.Entities.Models;

namespace rpg.API.Creator
{
    public class RpgCreator : ICreator
    {
        IUnitFactory unitFactory;

        public SwordsMan CreateSwordsMan()
        {
            unitFactory = new SwordsManFactory();
            return unitFactory.CreateUnit() as SwordsMan;
        }

        public Archer CreateArcher()
        {
            unitFactory = new ArcherFactory();
            return unitFactory.CreateUnit() as Archer;
        }

        public ArcherCaptain CreateArcherCaptain()
        {
            unitFactory = new ArcherCaptainFactory();
            return unitFactory.CreateUnit() as ArcherCaptain;
        }

        public Skeleton CreateSkeleton()
        {
            unitFactory = new SkeletonFactory();
            return unitFactory.CreateUnit() as Skeleton;
        }

        public Paladin CreatePaladin()
        {
            unitFactory = new PaladinFactory();
            return unitFactory.CreateUnit() as Paladin;
        }
    }
}
