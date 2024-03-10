namespace FoodAndIngredientStack;

public class IngredientStack
{
    FoodIngredient[] ingredients;
    int ingredientCount;

    public IngredientStack(int stackSize) {
        this.ingredients = new FoodIngredient[stackSize];
        this.ingredientCount = 0;
    }

    public bool Empty() {
        return 0 == ingredientCount;
    }

    public bool Full() {
        return ingredients.Length == ingredientCount;
    }

    public void Push(FoodIngredient newIngredient) {
        if (this.Full()) {
            throw new StackFullException(newIngredient);
        }

        this.ingredients[ingredientCount] = newIngredient;
        this.ingredientCount++;
    }

    public FoodIngredient Pop() {
        if (this.Empty()) {
            throw new StackEmptyException();
        }

        this.ingredientCount--;
        return this.ingredients[ingredientCount];
    }

    public FoodIngredient? Top() {
        if (this.Empty()) {
            return null;
        }

        return this.ingredients[ingredientCount - 1];
    }
}
