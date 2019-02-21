namespace BuilderPatternImplementation
{
    public class SedanBuilder : CarBuilder
    {
        public override void BuildDoors()
        {
            car.SetDoors(4);
        }

        public override void BuildRows()
        {
            car.SetRows(2);
        }

        public override void BuildSeats()
        {
            car.SetSeats(5);
        }
    }
}
