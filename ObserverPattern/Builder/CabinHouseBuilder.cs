using System;

namespace Builder
{
    public class CabinHouseBuilder : IHouseBuilder
    {
        public House Build()
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildDoors(int doors)
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildGarage()
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildGarden()
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildRoof()
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildRooms(int rooms)
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildWalls(int doors)
        {
            throw new NotImplementedException();
        }

        public IHouseBuilder BuildWindows(int windows)
        {
            throw new NotImplementedException();
        }
    }
}