namespace TestFoodAndIngredientStack;
using FoodAndIngredientStack;
using NUnit.Framework;

[TestFixture]
public class TestIngredientStack
{
    [SetUp]
    public void Setup() {

    }

    [TestCase(10)]
    public void TestStackIsEmpty(int stackSize)
    {
        IngredientStack ingredStack = new IngredientStack(stackSize);

        Assert.Throws<StackEmptyException>(() => ingredStack.Pop());
    }

    [TestCase(10)]
    public void TestStackIsFull(int stackSize)
    {
        IngredientStack ingredStack = new IngredientStack(stackSize);

        for (int i = 0; i < stackSize; i++) {
            ingredStack.Push(new FoodIngredient("Bananan", 1, FoodIngredient.UnitTypes.Pieces));
        }

        FoodIngredient lastItem = new FoodIngredient("Bananan", 1, FoodIngredient.UnitTypes.Pieces);
        StackFullException sfEx = Assert.Throws<StackFullException>(() => ingredStack.Push(lastItem));

        Assert.That(sfEx.Ingredient, Is.EqualTo(lastItem));
    }

    [TestCase(10)]
    public void TestStackTopt(int stackSize) {
        IngredientStack ingredStack = new IngredientStack(stackSize);

        for (int i = 0; i < stackSize / 2; i++) {
            ingredStack.Push(new FoodIngredient("Bananan", 1, FoodIngredient.UnitTypes.Pieces));
        }

        FoodIngredient lastItem = new FoodIngredient("Bread", 2, FoodIngredient.UnitTypes.Pieces);
        ingredStack.Push(lastItem);

        Assert.That(ingredStack.Top().ToString(), Is.EqualTo(lastItem.ToString()));
    }
}
