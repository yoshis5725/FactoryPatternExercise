namespace FactoryPatternExercise;

static class VehicleFactory
{
    public static IVehicle GetVehicle(int tireAmountEntered)
    {
        switch (tireAmountEntered)
        {
            case 2:
                return new Motorcycle();
            default:
                return new Car();
        }
    }
}