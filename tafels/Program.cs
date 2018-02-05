using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tafels
{
    class Program
    {
        static void Main(string[] args)
        {

            Table[] tafels = new Table[10] ;
            var rndGen = new Random();

            for(var i = 0; i < 10; i++)
            {
                var a = rndGen.Next(50, 200);
                var b = rndGen.Next(50, 200);
                tafels[i] = new Table(a, b);
                
            }

            foreach (var t in tafels)
            { 
                t.ShowData();
                
            }

        }

        
    }
}
