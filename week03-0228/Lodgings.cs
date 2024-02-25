namespace week03_0228;

public class Lodgings : Flat, IRent
{
    protected int bookedMonths;

    public bool IsBooked { get => 0 != this.bookedMonths; }

    public Lodgings(double area, int roomsCount, int unitPrice)
        : base(area, roomsCount, 0, unitPrice)
    {
        this.bookedMonths = 0;
    }

    public int GetCost(int months)
    {
        return this.TotalValue() / 240 / this.inhabitantsCount;
    }

    public bool Book(int months)
    {
        if (this.IsBooked) {
            return false;
        }

        this.bookedMonths = months;
        return true;
    }

    public override bool MoveIn(int newInhabitants)
    {
        int newPreasonCount = this.inhabitantsCount + newInhabitants;

        if (!this.IsBooked) {
            return false;
        }
        if (this.roomsCount < (newPreasonCount / 8)) {
            return false;
        }
        if (2 <= (newPreasonCount / this.area)) {
            return false;
        }

        this.inhabitantsCount =+ newInhabitants;
        return true;
    }
}
