using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_POCO
{
    public class Badge
    {
        public int ID { get; set; }
        public List<string> DoorNames { get; set; }
        public Badge()
        {

        }
        public Badge(int id,  List<string> doorNames)
        {
            ID = id;
            DoorNames = doorNames;
        }
    }
    

}
