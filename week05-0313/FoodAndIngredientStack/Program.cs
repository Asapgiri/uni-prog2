namespace FoodAndIngredientStack;

class Program
{
    static void PrintIngredients(string title, FoodIngredient[] ingredients) {
        Console.WriteLine(title + ":");
        for (int i = 0; i < ingredients.Length; i++) {
            Console.WriteLine("  - " + ingredients[i]);
        }
    }

    static void Main(string[] args)
    {
        FoodIngredient foodIngredient = new FoodIngredient("Bread", 3, FoodIngredient.UnitTypes.Pieces);

        Console.WriteLine(foodIngredient);

        IngredientStack ingredientStack = new IngredientStack(2);
        ingredientStack.Push(foodIngredient);
        IngredientStackHandler isHandler = new IngredientStackHandler(ingredientStack);

        FoodIngredient[] ingredientsToAdd = [
            new FoodIngredient("Milk",   3, FoodIngredient.UnitTypes.Liter),
            new FoodIngredient("Butter", 2, FoodIngredient.UnitTypes.Package)
        ];

        PrintIngredients("Trying to add", ingredientsToAdd);
        FoodIngredient[] notAddedIngredients = isHandler.AddItems(ingredientsToAdd);

        if (notAddedIngredients.Length > 0) {
            PrintIngredients("Ingredients not added", notAddedIngredients);
        }
        else {
            Console.WriteLine("All ingredients added!");
        }
    }
}
