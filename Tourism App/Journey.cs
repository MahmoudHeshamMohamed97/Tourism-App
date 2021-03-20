using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_App
{
    class Journey
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MaxNumber { get; set; }
        public Type TravelWay { get; set; }



        public virtual List<Ticket> Tickets { get; set; }

    }


    public enum Type
    {
        Bus,
        Plane
    }
}
