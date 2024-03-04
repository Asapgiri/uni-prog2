namespace stack;

public class Stack
{
    private char[] stackArray;
    private int itemsInStack;

    public Stack(int stackSize) {
        this.stackArray = new char[stackSize];
        this.itemsInStack = 0;
    }

    public bool Push(char newItem) {
        if (itemsInStack >= stackArray.Length) {
            return false;
        }

        stackArray[itemsInStack] = newItem;
        itemsInStack++;

        return true;
    }

    public bool Pop(out char item) {
        if (0 == itemsInStack) {
            item = (char)0;
            return false;
        }

        itemsInStack--;
        item = stackArray[itemsInStack];

        return true;
    }

    public bool Empty() {
        return 0 == itemsInStack;
    }

    public bool Full() {
        return stackArray.Length == itemsInStack;
    }
}
