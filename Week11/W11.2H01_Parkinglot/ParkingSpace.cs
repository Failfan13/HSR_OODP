public class ParkingSpace
{
    public int Row { get; set; }
    public int Col { get; set; }
    public int Size { get; set; }
    public bool IsOccupied
    {
        get => Vehicle != null;
    }
    public Vehicle Vehicle { get; set; } = null;

    public ParkingSpace(int row, int col, int size)
    {
        Row = row;
        Col = col;
        Size = size;
    }

    public bool ParkVehicle(Vehicle vehicle)
    {
        if (!IsOccupied)
        {
            Vehicle = vehicle;
            return true;
        }
        return false;
    }

    public Vehicle GetVehicle() => Vehicle;
}