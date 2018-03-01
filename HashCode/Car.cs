using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class Car
    {
        private int[ , ] coord;

        public int[,] Coord
        {
            get
            {
                return this.coord;
            }
            set
            {
                this.coord = value;
            }
        }


    }
}
