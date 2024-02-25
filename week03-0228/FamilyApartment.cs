namespace week03_0228;

public class FamilyApartment : Flat
{
    int childrenCount;

    public FamilyApartment(double area, int roomsCount, int unitPrice)
        : base(area, roomsCount, 0, unitPrice)
    {
        this.childrenCount = 0;
    }

    public bool ChildrenIsBorn() {
        if (this.inhabitantsCount >= (this.childrenCount + 2)) {
            this.childrenCount++;
            this.inhabitantsCount++;
            return true;
        }
        else {
            return false;
        }
    }

    public override bool MoveIn(int newInhabitants)
    {
        int parentCount = this.inhabitantsCount - childrenCount + newInhabitants;
        int personCount = parentCount + (childrenCount / 2);

        if (this.roomsCount < ((this.inhabitantsCount + newInhabitants) / 2)) {
            return false;
        }
        if (10 <= (personCount / this.area)) {
            return false;
        }

        this.inhabitantsCount += newInhabitants;
        return true;
    }
}
