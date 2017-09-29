using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            char dot = '.';
            int dotQuantity = n;
            char ds = '#';
            int dsQuantity = 3 * n;
            int inDotQuantity = 0;
            int result = 0;

            for (int rows = 0; rows < n / 2; rows++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dot, dotQuantity), new string(ds, dsQuantity));
                dotQuantity++;
                dsQuantity -= 2;
            }
            inDotQuantity = dsQuantity - 2;
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(dot, dotQuantity), new string(ds,1), new string(dot, inDotQuantity));
                dotQuantity++;
                inDotQuantity -= 2;
            }
            dsQuantity = 4 + inDotQuantity;
            dotQuantity--;
            Console.WriteLine("{0}{1}{0}", new string(dot, dotQuantity), new string(ds, dsQuantity));
            dsQuantity = dsQuantity + 4;
            dotQuantity = dotQuantity - 2;
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dot, dotQuantity), new string(ds, dsQuantity));
            }
            
            Console.WriteLine("{0}{1}{0}", new string(dot, dotQuantity), new string(ds, dsQuantity));
            result = n - 6;
            result = result / 2;
          
            dotQuantity += result;


            Console.WriteLine("{0}D^A^N^C^E^{0}", new string(dot, dotQuantity));
            dotQuantity -= result;
            for (int i = 0; i < (n/2)+1; i++)
            {
                            
                Console.WriteLine("{0}{1}{0}", new string(dot, dotQuantity), new string(ds, dsQuantity));
            }
        }
    }
}
