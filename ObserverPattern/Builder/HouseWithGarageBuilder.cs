using System;

namespace Builder
{
    public class HouseWithGarageBuilder : IHouseBuilder
    {
        private House _house;
        public HouseWithGarageBuilder()
        {
            this._house = new House("Palace");
        }
        public IHouseBuilder BuildDoors(int doors)
        {

            return this;
        }

        public IHouseBuilder BuildRoof()
        {

            Console.WriteLine("roof added");
            return this;
        }

        public IHouseBuilder BuildRooms(int rooms)
        {

            Console.WriteLine($" {rooms} room added");
            return this;
        }

        public IHouseBuilder BuildWalls(int walls)
        {
            Console.WriteLine($" {walls} walls added");
            return this;
        }

        public IHouseBuilder BuildWindows(int windows)
        {
            Console.WriteLine($" {windows} windows added");
            return this;
        }
        public IHouseBuilder BuildGarage()
        {
            Console.WriteLine("Garage added");
            return this;
        }
        public House Build()
        {
            House result = this._house;
            return result;
        }

        public IHouseBuilder BuildGarden()
        {
            Console.WriteLine("Garage added");
            return this;
        }
    }
}