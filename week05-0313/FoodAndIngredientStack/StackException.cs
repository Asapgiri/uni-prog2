namespace FoodAndIngredientStack;

public class StackException : Exception
{
    public FoodIngredient? Ingredient { get; private set; }

    public StackException(FoodIngredient? ingredient) {
        this.Ingredient = ingredient;
    }
}
