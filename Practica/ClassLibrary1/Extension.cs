using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //1-Crear un método de extensión que reciba un string y retorne la cantidad de palabras.
    public static class Extension
    {
        public static int CantidadPalabras(string cadena)
        {
            int cant = 0;
            string [] resultado = cadena.Split(' ');
            foreach (string s in resultado)
                cant++;

            return cant;
        }

        //2) Crear una sobreescritura del método 1 para
        //que reciba un parámetro adicional char con el separador a usar para contar las palabras.
        public static int CantidadPalabras(string cadena, char separador)
        {
            int cant = 0;
            string[] resultado = cadena.Split(separador);
            foreach (string s in resultado)
                cant++;

            return cant;
        }

        //3)Cree un método de extensión que reciba dos fechas DateTime y calcule su diferencia en segundos
        //y que retorne un decimal con su formato en minutos (en valor decimal, es de 120 = 2 o 180 = 2,5)
        public static decimal CalcularDiffFechas(DateTime fecha1, DateTime fecha2)
        {
            TimeSpan resta = fecha2.Subtract(fecha1);
            double diff = resta.TotalSeconds;
            return decimal.Parse(diff.ToString());
        }

        //4)Crear un método de extensión que reciba una lista de enteros y devuelva su promedio.
        public static double CalcularPromedio(List<int> lista)
        {
            return lista.Average();
        }

        //5)Crear un método de extensión que reciba una lista de enteros
        //y devuelva la suma de los valores pares * la resta de los impares.

    }
}
