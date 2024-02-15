namespace Practice_Inheritance_Hafsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            //instances
            Vehicle vehicle = new Vehicle("red");
            Air air = new Air("blue");
            Helicopter helicopter = new Helicopter(2, "pink");
            Plane plane = new Plane(4, "grey");
            Sea sea = new Sea((Type)1, "black");
            Land land = new Land(4, "green");

            //vehicle list
            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);

            //loop
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.ToString());
            }


        }//main


    }//class


}//namespace