namespace _4CarFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string type = "ar";
                string name = "Tesla";
                string make = "AMG";
                string model = "S";
                string year = "2020";
                double speed = 240;
                string wheels = "20'";
                double miles = 400;

                Vehicle vehicle = Factory.BuildViechle(type, name, make, model, year, speed, wheels, miles);
                Console.WriteLine($"Hello, {vehicle.GetVehicleInfo()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public double Speed { get; set; }
        public string Wheels { get; set; }
        public double Miles { get; set; }
        public Vehicle(string name, string make, string year, double speed, string wheels, double miles)
        {
            Id = Guid.NewGuid();
            Name = name;
            Make = make;
            Year = year;
            Speed = speed;
            Wheels = wheels;
            Miles = miles;
        }
        public virtual string GetVehicleInfo()
        {
            return $"You chose a {Name} with {Wheels} wheels made in {Year} that has a top speed of {Speed} and has traveled {Miles} miles.";
        }
    }
    public class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(string name, string model, string make, string year, double speed, string wheels, double miles)
            : base(name, make, year, speed, wheels, miles)
        {
            Model = model;
        }
        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo();
        }
    }
    public class Truck : Vehicle
    {
        public string Model { get; set; }
        public Truck(string name, string model, string make, string year, double speed, string wheels, double miles)
            : base(name, make, year, speed, wheels, miles)
        {
            Model = model;
        }
        public override string GetVehicleInfo()
        {
            return base.GetVehicleInfo();

        }
    }
    public class Factory
    {
        private HashSet<string> types = new HashSet<string>() { "car", "truck"};
        public static Vehicle BuildViechle(string type, string name, string make, string model, string year, double speed, string wheels, double miles)
        {
            switch(type.ToLower())
            {
                case "car":
                    Car car = new Car(name, model, make, year, speed, wheels, miles);
                    return car;
                case "truck":
                    Truck truck = new Truck(name, model, make, year, speed, wheels, miles);
                    return truck;
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}