namespace week03_0228;

public class Garage : IRent, IRealEstate
{
    double area;
    int unitPrice;
    bool isHeated;
    int months;
    bool isOccupied;

    public Garage(double area, int unitPrice, bool isHeated) {
        this.area = area;
        this.unitPrice = unitPrice;
        this.isHeated = isHeated;
    }

    public void UpdateOccupied() {
        this.isOccupied = !this.isOccupied;
    }

    public bool IsBooked { get => 0 != months || isOccupied; }

    public bool Book(int months)
    {
        if (IsBooked) {
            return false;
        }

        this.months = months;
        return true;
    }

    public int GetCost(int months)
    {
        int cost = this.TotalValue() / 120;
        if (isHeated) {
            cost = (int)((double)cost * 1.5);
        }
        return cost;
    }

    public int TotalValue()
    {
        return (int)(area * (double)unitPrice);
    }

    public override string ToString()
        {
            return $"Area: {area}m2, " +
                   $"unit price: {unitPrice} Ft/m2, " +
                   $"heated: {isHeated}, " +
                   $"months: {months}, " +
                   $"occupied: {isOccupied}";
        }
}
