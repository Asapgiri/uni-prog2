namespace week03_0228;

public abstract class Flat : IRealEstate
{
    protected double area;
    protected int roomsCount;
    protected int inhabitantsCount;
    protected int unitPrice;

    public int InhabitantsCount { get => inhabitantsCount; }

    public Flat(double area, int roomsCount, int inhabitantsCount, int unitPrice) {
        this.area = area;
        this.roomsCount = roomsCount;
        this.inhabitantsCount = inhabitantsCount;
        this.unitPrice = unitPrice;
    }

    public abstract bool MoveIn(int newInhabitants);

    public int TotalValue() {
        return (int)(area * (double)unitPrice);
    }

    public override string ToString() {
        // Should intact performance, but here not really matter
        return $"Area: {area}m2, " +
               $"rooms: {roomsCount}, " +
               $"inhabitants: {inhabitantsCount}, " +
               $"unit price: {unitPrice} Ft/m2";
    }
}
