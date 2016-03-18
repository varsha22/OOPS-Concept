using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Car
    {
        //necessary methods and properties exposed by using "public" access modifier &
        //unnecessary methods and properties (not compulsary) hidden by using "private" 
        //access modifier.
        private string _nameofcar = "My Car";

        private string _colorofcar = "Red";

        public string NameofCar
        {
            set { _nameofcar = value; }
            get { return _nameofcar; }
        }

        public string ColorofCar
        {
            set
            {
                _colorofcar = value;
            }

            get
            {
                return _colorofcar;
            }

        }

        public void Steering()
        {
            Console.WriteLine("Streering of Car");
        }


        public void RearViewMirror()
        {
            Console.WriteLine("RearViewMirror of Car");
        }



        public void Brakes()
        {
            Console.WriteLine("Brakes of Car");
        }

        public void Gear()
        {
            Console.WriteLine("Gear of Car");
        }


        private void InternalDetailsofCar()
        {
            Console.WriteLine("InternalDetailsofCar of Car");
        }



        private void CarEngine()
        {
            Console.WriteLine("CarEngine of Car");
        }

        private void DiesalEngine()
        {
            Console.WriteLine("DiesalEngine of Car");
        }

        private void ExhaustSystem()
        {
            Console.WriteLine("ExhaustSystem of Car");
        }

        private void Silencer()
        {
            Console.WriteLine("Silencer of Car");
        }
    }
}
