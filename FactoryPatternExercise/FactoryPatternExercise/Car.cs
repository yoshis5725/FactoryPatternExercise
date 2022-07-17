namespace FactoryPatternExercise;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("The car is in drive");
    }
}