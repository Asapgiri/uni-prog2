namespace week03_0228;

public class ApartmentHouse
{
    int flatCount;
    int garageCount;
    int occupiedFlatCount;
    int occupiedGarageCount;

    public IRealEstate[] Propertys { get; private set; }

    public int InhabitantCount {
        get {
            int totalCount = 0;
            for (int i = 0; i < (this.occupiedFlatCount + this.occupiedGarageCount); i++) {
                if (this.Propertys[i] is Flat) {
                    totalCount += (this.Propertys[i] as Flat).InhabitantsCount;
                }
            }
            return totalCount;
        }
    }

    public ApartmentHouse(int flatCount, int garageCount) {
        this.flatCount = flatCount;
        this.garageCount = garageCount;

        this.occupiedFlatCount = 0;
        this.occupiedGarageCount = 0;

        this.Propertys = new IRealEstate[this.flatCount + this.garageCount];
    }

    public bool OccupyProperty(IRealEstate newProperty) {
        if (newProperty is Flat) {
            if (this.flatCount <= this.occupiedFlatCount) {
                return false;
            }
            this.occupiedFlatCount++;
        }
        else if (newProperty is Garage) {
            if (this.garageCount <= this.occupiedGarageCount) {
                return false;
            }
            this.occupiedGarageCount++;
        }
        else {
            return false;
        }

        this.Propertys[this.occupiedFlatCount + this.occupiedGarageCount - 1] = newProperty;
        return true;
    }

    public int TotalValue() {
        int totalValue = 0;

        for (int i = 0; i < (this.occupiedFlatCount + this.occupiedGarageCount); i++) {
            if (this.Propertys[i] is Flat && (this.Propertys[i] as Flat).InhabitantsCount > 0) {
                totalValue += this.Propertys[i].TotalValue();
            }
            else if (this.Propertys[i] is Garage && (this.Propertys[i] as Garage).IsBooked) {
                totalValue += this.Propertys[i].TotalValue();
            }
        }

        return totalValue;
    }

    private static (int, int) CountLines(string fileName) {
        int flats = 0;
        int garages = 0;
        string line;
        string[] parameters;
        StreamReader sr = new StreamReader(fileName);

        while (null != (line = sr.ReadLine())) {
            parameters = line.Split(' ');
            if ("Alberlet" == parameters[0]) {
                flats++;
            }
            else if ("CsaladiApartman" == parameters[0]) {
                flats++;
            }
            else if ("Garazs" == parameters[0]) {
                garages++;
            }
        }
        sr.Close();

        return (flats, garages);
    }

    public static ApartmentHouse LoadFromFile(string fileName) {
        if (!File.Exists(fileName)) {
            Console.WriteLine($"File '{fileName}' does not exists!");
            return null;
        }

        int flats, garages; 
        (flats, garages) = ApartmentHouse.CountLines(fileName);
        ApartmentHouse newAptH = new ApartmentHouse(flats, garages);
        StreamReader sr = new StreamReader(fileName);
        string line;
        string[] parameters;

        while (null != (line = sr.ReadLine())) {
            parameters = line.Split(' ');
            if ("Alberlet" == parameters[0]) {
                newAptH.OccupyProperty(new Lodgings(
                    double.Parse(parameters[1]), // area
                    int.Parse(parameters[2]), // rooms count
                    int.Parse(parameters[3])  // unit price
                ));
            }
            else if ("CsaladiApartman" == parameters[0]) {
                newAptH.OccupyProperty(new FamilyApartment(
                    double.Parse(parameters[1]), // area
                    int.Parse(parameters[2]), // rooms count
                    int.Parse(parameters[3])  // unit price
                ));
            }
            else if ("Garazs" == parameters[0]) {
                newAptH.OccupyProperty(new Garage(
                    double.Parse(parameters[1]), // area
                    int.Parse(parameters[2]), // unit price
                    "futott" == parameters[3]  // is heated
                ));
            }
        }
        sr.Close();

        return newAptH;
    }
}
