using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tafels
{
    class Table
    {

        private int height;
        private int width;


        public Table(int height,int width)
        {
            this.height = height;
            this.width = width;
        }


        public void ShowData()
        {
            Console.WriteLine("de hoogte is {0} en de breedte is {1}",height,width);

        }



    }
}
