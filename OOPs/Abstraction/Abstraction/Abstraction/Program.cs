using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Car objCar = new Car();
            string name = objCar.NameofCar;
            objCar.Steering();
            objCar.RearViewMirror();
            objCar.Brakes();
            //Cannot access an example of abstaction/
            //objCar.CarEngine();
        }
    }


    /// <summary>
    /// Abstraction means putting all the variables and methods in a class that are necessary.
    /// For example: Abstract class and abstract method.
    /// Abstraction is a common thing.
    /// </summary>
    abstract class MobilePhone
    {
        public void Calling();
        public void SendSMS();
    }
    public class Nokia1400 : MobilePhone
    {
    }
    public class Nokia2700 : MobilePhone
    {
        public void FMRadio();
        public void MP3();
        public void Camera();
    }
    public class BlackBerry : MobilePhone
    {
        public void FMRadio();
        public void MP3();
        public void Camera();
        public void Recording();
        public void ReadAndSendSMS();
    }
}
