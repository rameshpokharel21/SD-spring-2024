public static class RacingLineup
{
    private readonly static string[] _numbers = { "03", "12", "14", "23", "28", "31", "41" };
    public static List<Car> Cars = new List<Car>();

    public static List<Car> BuildLineup()
    {
        foreach (string number in _numbers)
        {
            Car car = new Car(number);
            Cars.Add(car);
        }
        return Cars;
    }
}