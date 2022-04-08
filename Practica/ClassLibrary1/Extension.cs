using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    //1-Crear un método de extensión que reciba un string y retorne la cantidad de palabras.
    public static class Extension
    {
        public static int CantidadPalabras(this string cadena)
        {
            int cant = 0;
            string [] resultado = cadena.Split(' ');
            foreach (string s in resultado)
                cant++;

            return cant;
        }

        //2) Crear una sobreescritura del método 1 para
        //que reciba un parámetro adicional char con el separador a usar para contar las palabras.
        public static int CantidadPalabras(this string cadena, char separador)
        {
            int cant = 0;
            string[] resultado = cadena.Split(separador);
            foreach (string s in resultado)
                cant++;

            return cant;
        }

        //3)Cree un método de extensión que reciba dos fechas DateTime y calcule su diferencia en segundos
        //y que retorne un decimal con su formato en minutos (en valor decimal, es de 120 = 2 o 180 = 2,5)
        public static decimal CalcularDiffFechas(this DateTime fecha1,this DateTime fecha2)
        {
            TimeSpan resta = fecha2.Subtract(fecha1);
            double diff = resta.TotalSeconds / 60;
            return decimal.Parse(diff.ToString());
        }

        //4)Crear un método de extensión que reciba una lista de enteros y devuelva su promedio.
        public static double CalcularPromedio(this List<int> lista)
        {
            return lista.Average();
        }

        //5)Crear un método de extensión que reciba una lista de enteros
        //y devuelva la suma de los valores pares * la resta de los impares.
        public static int CalcularProducto(this List<int> lista)
        {
            int suma = 0;
            int resta = 0;

            foreach (int n in lista)
            {
                if (n % 2 == 0)
                    suma += n;
                else
                    resta = resta - n;                
            }

            return suma*resta;
        }

        //6)crear un método de extensión que retorne una fecha en formato datetime a partir de un string
        //(si se genera una excepción por mal formato retornar el MinValue del tipo de datos).
        public static DateTime StringAFecha(this string fecha)
        {
            return DateTime.Parse(fecha);
        }

        //7)	Crear un método de extensión que dado un string, retorne otro invertido.
        public static string InvertirCadena(this string palabra)
        {
            char[] Invertido = palabra.ToArray();
            Array.Reverse(Invertido);
            return new string(Invertido);
        }

        //8)	Crear un método de extensión que dado un array de strings, 
        //genere un solo string separado por un parámetro de tipo char.
        public static string UnirArray(this List<string> lista, char parametro)
        {
            string resultado = "";
            foreach (string x in lista)
                resultado += x + parametro;

            return resultado;
        }

        //9)	Crear un método de extensión que reciba un string 
        //y retorne un valor booleano que indique si es un correo electrónico o no

        public static bool EsCorreo(this string correo)
        {
            Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (rx.IsMatch(correo))
                return true;
            return false;
        }

        //10)	Crear un método de extensión que reciba un string y retorne
        //un valor booleano que indique si es un CUIT o no (investigar Regex).
        public static bool EsCUIT(this string cuit)
        {
            Regex rx = new Regex(@"^\d{2}\-\d{8}\-\d{1}$");
            if (rx.IsMatch(cuit))
                return true;
            return false;
        }

    }
}
