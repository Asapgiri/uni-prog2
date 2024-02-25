namespace week03_0228;

public interface IRent
{
    bool IsBooked { get; }

    int GetCost(int months);
    bool Book(int months);
}
