using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleg_2
{
    

    class Program
    {
        public static float M()
        {
            return 0;
        }

        static void Main(string[] args)
        {

            Action<Func<float>, bool, List<float>> A= null;
            Func<float> func = null;
            func += M;

           

            A += ((params1, params2, params3) =>

             Console.WriteLine("Y")
            

            );


            A?.Invoke(func, true,null);
            
           
         
        }


 

        

        

    }
}
