using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo_1 =
                new Equipo("Equipo 1");

            Equipo equipo_2 =
                new Equipo("Equipo 2");

            equipos.Add(equipo_1);
            equipos.Add(equipo_2);


        }
    }
}
