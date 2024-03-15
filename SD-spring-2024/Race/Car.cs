public class Car
{
    public string Number { get; private set; }
    public int Position { get; private set; } = 0;

    public Car(string number)
    {
        Number = number;
    }

    public void MoveForward(int distance)
    {
        Position += distance;
    }
}