namespace ProxyPatternImplementation
{
    public class CarProxy : ICar
    {
        private Car _car;

        public string TurnOn()
        {
            CheckCar();
            return _car.TurnOn();
        }

        public string TurnOff()
        {
            CheckCar();
            return _car.TurnOff();
        }

        private void CheckCar()
        {
            if (_car == null)
                _car = new Car();
        }
    }
}
