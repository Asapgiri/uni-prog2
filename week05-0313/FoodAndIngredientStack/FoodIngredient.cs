namespace FoodAndIngredientStack;

public class FoodIngredient
{
    public enum UnitTypes {
        Liter = 0,
        Kilogramm = 1,
        Pieces = 2,
        Package = 3
    }

    string name;
    int quantity;
    UnitTypes unit;

    public FoodIngredient(string name, int quantity, UnitTypes unit) {
        this.name = name;
        this.quantity = quantity;
        this.unit = unit;
    }

    public override string ToString() {
        return $"{name}: {quantity} {unit}";
    }
}
