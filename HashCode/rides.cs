using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    class Rides
    {
      

        public Coords Start_coord { get; set; }
        public Coords Finish_coord { get; set; }
        public int earliest { get; set; }
        public int latest { get; set; }
        public Rides(int x1, int y1, int x2, int y2, int t1, int t2)
        {
            Start_coord=new Coords( x1,x2);
         
            Finish_coord = new Coords( x2,y2);
          
            earliest = t1;
            latest = t2;

        }
        

    }
}
