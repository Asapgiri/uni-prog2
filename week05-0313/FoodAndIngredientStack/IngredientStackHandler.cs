namespace FoodAndIngredientStack;

public class IngredientStackHandler
{
    IngredientStack ingredientStack;

    public IngredientStackHandler(IngredientStack ingredientStack) {
        this.ingredientStack = ingredientStack;
    }

    public FoodIngredient[] AddItems(FoodIngredient[] foodIngredients) {
        int i = 0;
        FoodIngredient[] retIngredients;

        try {
            for (i = 0; i < foodIngredients.Length; i++) {
                ingredientStack.Push(foodIngredients[i]);
            }
        }
        catch (StackFullException) {
        }
        finally {
            int iAtExceptionTime = i;
            int retLength = foodIngredients.Length - i;
            retIngredients = new FoodIngredient[retLength];
            for (i = 0; i < retLength; i++) {
                retIngredients[i] = foodIngredients[i + iAtExceptionTime];
            }
        }

        return retIngredients;
    }
}
