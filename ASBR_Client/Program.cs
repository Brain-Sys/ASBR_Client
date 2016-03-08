using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ASBR_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            var cf = new ChannelFactory<IProblemSolverChannel>("solver");
            var ch = cf.CreateChannel();

            for (int i = 0; i < 1000; i++)
            {
                int a = rnd.Next(1, 100);
                int b = rnd.Next(1, 100);
                Console.WriteLine("Richiesta " + (i + 1));
                Console.WriteLine(ch.AddNumbers(a, b));
            }

            Console.ReadKey();
        }
    }
}