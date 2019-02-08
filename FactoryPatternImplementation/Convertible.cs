namespace FactoryPatternImplementation
{
    public class Convertible : IVehicle
    {
        public string TurnOn() => "Convertible turned on!";
        public string TurnOff() => "Convertible turned off!";
    }
}
