namespace FoodAndIngredientStack;

public class StackFullException : StackException
{
    public StackFullException(FoodIngredient ingredient) : base(ingredient) {}
}
