public class ParkingLot
{
    public int[] NumColsArr { get; }
    private ParkingSpace[][] ParkingSpaces;

    public ParkingLot(int[] numCols)
    {
        NumColsArr = numCols;

        CreateParkings();
    }

    private void CreateParkings()
    {
        ParkingSpaces = new ParkingSpace[NumColsArr.Length][];

        for (int i = 0; i < NumColsArr.Length; i++)
        {
            ParkingSpace[] spaces = new ParkingSpace[NumColsArr[i]];

            for (int j = 0; j < NumColsArr[i]; j++)
            {
                spaces[j] = new ParkingSpace(i, j, (NumColsArr[i] > 4) ? 1 : 2);
            }

            ParkingSpaces[i] = spaces;
        }
    }

    public bool ParkVehicle(Vehicle vehicle, ParkingSpace space)
    {
        if (!space.IsOccupied)
        {
            return space.ParkVehicle(vehicle);
        }
        return false;
    }

    public ParkingSpace FindAvailableSpace(Vehicle vehicle)
    {
        for (int i = 0; i < ParkingSpaces.Length; i++)
        {
            for (int j = 0; j < ParkingSpaces[i].Length; j++)
            {
                if (ParkingSpaces[i][j].IsOccupied == false &&
                    ParkingSpaces[i][j].Size == vehicle.Size)
                    return ParkingSpaces[i][j];
            }
        }
        return null;
    }

    public int NumCarsParked() => HowManyParked(typeof(Car));
    public int NumTrucksParked() => HowManyParked(typeof(Truck));

    private int HowManyParked(Type type)
    {
        int found = 0;

        for (int i = 0; i < ParkingSpaces.Length; i++)
        {
            for (int j = 0; j < ParkingSpaces[i].Length; j++)
            {
                if (ParkingSpaces[i][j].Vehicle != null && ParkingSpaces[i][j].Vehicle.GetType() == type) found++;
            }
        }

        return found;
    }
}

