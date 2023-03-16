using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================Bulider Pattern===============");
            Director d = new Director();

            IBulider carBulider = new Car("BMW");
            IBulider motorBulider = new MotorCycle("Honda");

            //making car
            d.Construct(carBulider);
            Product car = carBulider.GetVechicle();
            Console.WriteLine($"Car : {car.Show()}");


            //making MotorCycle
            d.Construct(motorBulider);
            Product motorCycle = motorBulider.GetVechicle();
            Console.WriteLine($"Car : {motorCycle.Show()}");


            Console.ReadKey();

        }
    }
}
