namespace week03_0228;

public class Program
{
    public static void Main() {
        ApartmentHouse ah = ApartmentHouse.LoadFromFile("apartments.txt");

        Console.WriteLine(ah.TotalValue());
        Console.WriteLine(ah.Propertys.Length);

        FamilyApartment fam = new FamilyApartment(50.0, 2, 500000);
        Lodgings lod        = new Lodgings(50.0, 2, 500000);
        Garage gar          = new Garage(10.0, 50000, true);

        IRealEstate[] rentables = new IRealEstate[3];
        rentables[0] = lod;
        rentables[1] = fam;
        rentables[2] = gar;

        fam.MoveIn(2);
        lod.MoveIn(4);
        gar.Book(5);

        ApartmentHouse aptH = new ApartmentHouse(5, 5);
        for (int i = 0; i < rentables.Length; i++) {
            aptH.OccupyProperty(rentables[i]);
        }

        Console.WriteLine(aptH.TotalValue());
        Console.WriteLine(aptH.Propertys.Length);
    }
}
