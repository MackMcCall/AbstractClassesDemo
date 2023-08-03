using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            var vehicles = new List<Vehicle>();


            Car camry = new Car()
            {
                Year = "2012",
                Make = "Toyota",
                Model = "Camry",
                HasTrunk = true
            };

            Motorcycle harley = new Motorcycle()
            {
                Year = "1980",
                Make = "Harley - Davidson",
                Model = "Breakout",
                HasSideCart = false
            };

            Vehicle lambo = new Car()
            {
                Year = "2023",
                Make = "Lamborghini",
                Model = "Huracan",
                HasTrunk = true
            };

            Vehicle ninja = new Motorcycle()
            {
                Year = "2018",
                Make = "Kawasaki",
                Model = "Ninja",
                HasSideCart = false
            };

            vehicles.Add(camry);
            vehicles.Add(harley);
            vehicles.Add(lambo);
            vehicles.Add(ninja);

            foreach (Vehicle whip in vehicles)
            {
                Console.WriteLine($"{whip.Year}\n{whip.Make}\n{whip.Model}\n");
            }

            
            camry.DriveAbstract();
            camry.DriveVirtual();

            harley.DriveAbstract();
            harley.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
}
}
