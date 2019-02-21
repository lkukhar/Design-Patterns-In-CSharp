namespace BuilderPatternImplementation
{
    public class CoupeBuilder : CarBuilder
    {
        public override void BuildDoors()
        {
            car.SetDoors(2);
        }

        public override void BuildRows()
        {
            car.SetRows(2);
        }

        public override void BuildSeats()
        {
            car.SetSeats(2);
        }
    }
}
