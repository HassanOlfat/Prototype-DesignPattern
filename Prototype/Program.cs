using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Prototype pattern demo";

            FourWheelar car = new FourWheelar();

            car.VehicleType = "Prototype";

            car.Brand = "Volvo";

            car.Model = "Swift";

            car.MoreInfo.Cost = "6.5 Lakhs INR";

            car.MoreInfo.Ratings = 2;
            //////////////////////////////////// Shallow Copy ////////////////////////////////

            FourWheelar truck = car.ShallowCopy() as FourWheelar;

            truck.VehicleType = "Truck";

            truck.Brand = "Tata";

            truck.Model = "ACE";

            truck.MoreInfo.Cost = "5 Lakhs INR";

            truck.MoreInfo.Ratings = 8;

            Console.WriteLine("******************************Shallow Copy******************************");

            Console.WriteLine("Origional Object:");

            car.ShowDetails();

            Console.WriteLine();

            Console.WriteLine("Shallow Cloned Object:");

            truck.ShowDetails();



            //////////////////////////////// Deep Copy ///////////////////////////////////
            FourWheelar truckNew = car.Clone() as FourWheelar;

            truckNew.VehicleType = "Truck";

            truckNew.Brand = "Tata120";

            truckNew.Model = "ACE";

            truckNew.MoreInfo.Cost = "4.5 Lakhs INR";

            truckNew.MoreInfo.Ratings = 4;

            Console.WriteLine("******************************Deep Copy******************************");

            Console.WriteLine("Origional Object:");

            car.ShowDetails();

            Console.WriteLine();

            Console.WriteLine("Deep Cloned Object:");

            truckNew.ShowDetails();
            Console.ReadKey();
        }
    }
}
