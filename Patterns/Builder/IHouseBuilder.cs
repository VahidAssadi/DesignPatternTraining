namespace Builder
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildWalls(int doors);
        IHouseBuilder BuildRoof();
        IHouseBuilder BuildRooms(int rooms);
        IHouseBuilder BuildWindows(int windows);
        IHouseBuilder BuildDoors(int doors);
        IHouseBuilder BuildGarage();
        IHouseBuilder BuildGarden();

        House Build();

    }
}