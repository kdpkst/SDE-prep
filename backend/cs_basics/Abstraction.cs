using System;

namespace Abstraction{

    public class Abstraction{
        static void Main(string[] args){

        }
    }

    public abstract class Plants{
        public abstract void grow();
    }


    public class Cactus : Plants
    {
        public override void grow()
        {
            Console.WriteLine("cactus grows in the desert...");
        }
    }

    public class Lotus : Plants
    {
        public override void grow()
        {
            Console.WriteLine("lotus grows in the water...");
        }
    }


}
