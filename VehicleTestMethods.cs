using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbstrack_ve_Interface
{
    public class VehicleTestMethods
    {
        public interface IVehicle
        {
            void go();

            void stop();
        }
        public interface IRideable
        {
            void Ride();
        }
        public interface IFlyable
        {
            void Soar();
        }

        public abstract class BaseVehicle : IVehicle
        {
            public void go()
            {
                Console.WriteLine("Araç gidiyor....");
            }
            public void stop()
            {
                Console.WriteLine("Araç duruyor....");
            }
        }

        public class Car : BaseVehicle
        {

        }

        public class Bike : BaseVehicle, IRideable
        {
            public void Ride()
            {
                Console.WriteLine("Araç biniliyor....");
            }
        }

        public class Plane : BaseVehicle, IFlyable
        {
            public void Soar()  // süzülmek
            {
                Console.WriteLine("Araç süzülüyor....");
            }
        }
    }

}
