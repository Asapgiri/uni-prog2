namespace apartman_house;

public class Flat : IFlat
{
    string owner;
    int area;
    int unitPrice;

    public Flat(string owner, int area, int unitPrice) {
        this.owner = owner;
        this.area = area;
        this.unitPrice = unitPrice;
    }

    public int TotalValue()
    {
        return area * unitPrice;
    }

    public override string ToString() {
        return $"{owner}: {area}m2, {TotalValue()} Ft";
    }
}
