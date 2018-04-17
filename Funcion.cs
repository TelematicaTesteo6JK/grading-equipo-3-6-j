using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeo
{

    public class Funcion
    {

        public static string australianGrade (double cal)
        {
            string temporal = "";
            if (cal < 0.00)
            {
                temporal = "invalid";
            }
            else if (cal >= 0.00 && cal <= 49.99)
            {
                temporal = "fail";
            }
            else if (cal >= 50.00 && cal <= 62.99)
            {
                temporal = "passC";
            }
            else if (cal >= 63.00 && cal <= 72.99)
            {
                temporal = "creditB";
            }
            else if (cal >= 73.00 && cal <= 82.99)
            {
                temporal = "distinctionA";
            }
            else if (cal >= 83.00 && cal <= 100.00)
            {
                temporal = "highDistinctionA";
            }
            else
                temporal = "invalid";

            return temporal;

        }

    }

}
