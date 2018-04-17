using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeo
{
    class Program
    {
        static void Main(string[] args)
        {

            string rutaCompleta = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.txt";
            string texto = "";
            texto += "Text Data" + " | " + "Expected Result" + " | " + "Actual Result" + "    | " + "Pass/Fail" + Environment.NewLine;

            if (Funcion.australianGrade(103.00)=="invalid")
            texto += "103.00" + "     " + " Invalid" + "           " +Funcion.australianGrade(103.00) + "            " + "Pass" + Environment.NewLine;
            else
            texto += "103.00" + "     " + " Invalid" + "           " +Funcion.australianGrade(103.00) + "            " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(90.00) == "highDistinctionA")
                texto += "90.00" + "       " + "HD" + "                " + Funcion.australianGrade(90.00) + "   " + "Pass" + Environment.NewLine;
            else
                texto += "90.00" + "       " + "HD" + "                " + Funcion.australianGrade(90.00) + "   " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(75.00) == "distinctionA")
                texto += "75.00" + "       " + "D" + "                 " + Funcion.australianGrade(75.00) + "       "+ "Pass" + Environment.NewLine;
            else
                texto += "75.00" + "       " + "D" + "                 " + Funcion.australianGrade(75.00) + "       " + "Fail" + Environment.NewLine;


            if (Funcion.australianGrade(65.00) == "creditB")
                texto += "65.00" + "       " + "C" + "                 " + Funcion.australianGrade(65.00) + "            " + "Pass" + Environment.NewLine;
            else
                texto += "65.00" + "       " + "C" + "                 " + Funcion.australianGrade(65.00) + "            " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(55.00) == "passC")
                texto += "55.00" + "       " + "P" + "                 " + Funcion.australianGrade(55.00) + "              " + "Pass" + Environment.NewLine;
            else
                texto += "55.00" + "       " + "P" + "                 " + Funcion.australianGrade(55.00) + "              " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(20.00) == "fail")
                texto += "20.00" + "       " + "N" + "                 " + Funcion.australianGrade(20.00) + "               " + "Pass" + Environment.NewLine;
            else
                texto += "20.00" + "       " + "N" + "                 " + Funcion.australianGrade(20.00) + "               " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(-1.00) == "invalid")
                texto += "-1.00" + "       " + "Invalid" + "           " + Funcion.australianGrade(-1.00) + "            " + "Pass" + Environment.NewLine;
            else
                texto += "-1.00" + "       " + "Invalid" + "           " + Funcion.australianGrade(-1.00) + "            " + "Fail" + Environment.NewLine + Environment.NewLine;

            texto += "-------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

            //Siguiente Tabla.
            texto += "Text Data" + " | " + "Expected Result" + " | " + "Actual Result" + "    | " + "Pass/Fail" + Environment.NewLine;   
            if (Funcion.australianGrade(120.00) == "invalid")
                texto += "120.00" + "      " + "Invalid" + "           " + Funcion.australianGrade(120.00) + "            " + "Pass" + Environment.NewLine;
            else
                texto += "120.00" + "      " + "Invalid" + "           " + Funcion.australianGrade(120.00) + "            " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(100.00) == "highDistinctionA")
                texto += "100.00" + "      " + "HD" + "                " + Funcion.australianGrade(100.00) + "   " + "Pass" + Environment.NewLine;
            else
                texto += "100.00" + "      " + "HD" + "                " + Funcion.australianGrade(100.00) + "   " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(83.00) == "highDistinctionA")
                texto += "83.00" + "       " + "HD" + "                " + Funcion.australianGrade(83.00) + "   " + "Pass" + Environment.NewLine;
            else
                texto += "83.00" + "       " + "HD" + "                " + Funcion.australianGrade(83.00) + "   " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(82.99) == "distinctionA")
                texto += "82.99" + "       " + "D" + "                 " + Funcion.australianGrade(82.99) + "       " + "Pass" + Environment.NewLine;
            else
                texto += "82.99" + "       " + "D" + "                 " + Funcion.australianGrade(82.99) + "       " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(73.00) == "distinctionA")
                texto += "73.00" + "       " + "D" + "                 " + Funcion.australianGrade(73.00) + "       " + "Pass" + Environment.NewLine;
            else
                texto += "73.00" + "       " + "D" + "                 " + Funcion.australianGrade(73.00) + "       " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(72.99) == "creditB")
                texto += "72.99" + "       " + "C" + "                 " + Funcion.australianGrade(72.99) + "            " + "Pass" + Environment.NewLine;
            else
                texto += "72.99" + "       " + "C" + "                 " + Funcion.australianGrade(72.99) + "            " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(63.00) == "creditB")
                texto += "63.00" + "       " + "C" + "                 " + Funcion.australianGrade(63.00) + "            " + "Pass" + Environment.NewLine;
            else
                texto += "63.00" + "       " + "C" + "                 " + Funcion.australianGrade(63.00) + "            " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(62.99) == "passC")
                texto += "62.99" + "       " + "P" + "                 " + Funcion.australianGrade(62.99) + "              " + "Pass" + Environment.NewLine;
            else
                texto += "62.99" + "       " + "P" + "                 " + Funcion.australianGrade(62.99) + "              " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(50.00) == "passC") 
                texto += "50.00" + "       " + "P" + "                 " + Funcion.australianGrade(50.00) + "              " + "Pass" + Environment.NewLine;
            else
                texto += "50.00" + "       " + "P" + "                 " + Funcion.australianGrade(50.00) + "              " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(49.99) == "fail")
                texto += "49.99" + "       " + "N" + "                 " + Funcion.australianGrade(49.99) + "               " + "Pass" + Environment.NewLine;
            else
                texto += "49.99" + "       " + "N" + "                 " + Funcion.australianGrade(49.99) + "               " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(0.00) == "fail")
                texto += "0.00" + "        " + "N" + "                 " + Funcion.australianGrade(0.00) + "               " + "Pass" + Environment.NewLine;
            else
                texto += "0.00" + "        " + "N" + "                 " + Funcion.australianGrade(0.00) + "               " + "Fail" + Environment.NewLine;

            if (Funcion.australianGrade(-1.00) == "invalid")
                texto += "-1.00" + "       " + "Invalid" + "           " + Funcion.australianGrade(-1.00) + "            " + "Pass" + Environment.NewLine;
            else
                texto += "-1.00" + "       " + "Invalid" + "           " + Funcion.australianGrade(-1.00) + "            " + "Fail" + Environment.NewLine + Environment.NewLine;

            using (StreamWriter reporte = File.CreateText(rutaCompleta))
            {
                reporte.WriteLine(texto);
                reporte.Close();
            }

            Console.Write("Reporte creado en el escritorio!!");
            Console.Read();

        }
    }
}
