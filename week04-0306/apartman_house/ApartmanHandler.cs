namespace apartman_house;

public class ApartmanHandler
{
    ILoadFlats fileLoader;
    IFlat[] flats;

    public ApartmanHandler(ILoadFlats fileLoader) {
        this.fileLoader = fileLoader;
        this.flats = new Flat[0];
    }

    public void LoadFlatsFromFile() {
        if (!fileLoader.Exists()) {
            return;
        }

        string[] loadedFlats = fileLoader.LoadLines();
        string[] parameters;
        flats = new Flat[loadedFlats.Length];

        for (int i = 0; i < loadedFlats.Length; i++) {
            parameters = loadedFlats[i].Split(" ");
            flats[i] = new Flat(
                parameters[0],
                int.Parse(parameters[1]),
                int.Parse(parameters[2])
            );
        }
    }

    public int Count() {
        return flats.Length;
    }
}
