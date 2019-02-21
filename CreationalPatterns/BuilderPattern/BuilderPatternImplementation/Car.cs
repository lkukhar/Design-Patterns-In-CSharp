namespace BuilderPatternImplementation
{
    public class Car
    {
        private int _doors;
        private int _seats;
        private int _rows;

        public void SetDoors(int doors)
        {
            _doors = doors;
        }

        public void SetSeats(int seats)
        {
            _seats = seats;
        }

        public void SetRows(int rows)
        {
            _rows = rows;
        }

        public string DescribeCar() => @"Doors: " + _doors.ToString() + ", Seats: " + _seats.ToString() + ", Rows: " + _rows.ToString() + ".";
    }
}
