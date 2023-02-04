using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Director
    {
        IHouseBuilder _builder;
        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }
        public void BuildWithGarage()
        {
            _builder
                .BuildRoof()
                .BuildWalls(4)
                .BuildRooms(2)
                .BuildDoors(2).BuildGarage().Build();
        }

        public void BuildWithGarden()
        {
            _builder
                .BuildRoof()
                .BuildWalls(4)
                .BuildRooms(2)
                .BuildDoors(2).BuildGarden().Build();
        }
    }
}
