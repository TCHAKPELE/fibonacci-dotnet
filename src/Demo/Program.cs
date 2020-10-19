using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace Demo
{


    

    

    class Program
    {
        public static int Fib(int a){

    if(a<1){

        return 1;
    }
    else{

return Fib(a-2)+Fib(a-1);
    }
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

            var results = new ConcurrentBag<int>();

            
            Parallel.ForEach(args ,(arg)=>
            {

                  var result =  Fib(int.Parse(arg));
                results.Add(result); 
            });
            
            
foreach(var a in results){
 Console.WriteLine($"Result : { a } ");

}
            stopwatch.Stop();

Console.WriteLine(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));


        }
    }
}
