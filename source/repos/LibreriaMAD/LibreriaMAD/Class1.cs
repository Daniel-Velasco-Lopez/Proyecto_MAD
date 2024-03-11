using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibreriaMAD
{
    public class Registro
    {
        public static int ValoresR()
        {
            Random r = new Random();

            Console.WriteLine(r.Next(0, 10000));
            Console.ReadLine();
            return r.Next();    
        }

    }
}