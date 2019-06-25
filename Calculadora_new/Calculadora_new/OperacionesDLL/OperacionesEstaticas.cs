using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Clase Estatica:no nescestia  pedir memoria para ser usado 
/// </summary>
namespace OperacionesDLL
{
    public class OperacionesEstaticas
    {


        //Suma
        public static  double Suma(string num1, string num2)
        {

            double resultado = Convert.ToDouble(num1)+ Convert.ToDouble(num2);
            return resultado;

        }

        //Resta

        public static double Resta(string num1, string num2)
        {

            double resultado = Convert.ToDouble(num1) - Convert.ToDouble(num2);
            return resultado;

        }



        //Multiplicacion

        public static double Multiplicacion(string num1, string num2)
        {

            double resultado = Convert.ToDouble(num1) * Convert.ToDouble(num2);
            return resultado;

        }

        //Division
        public static double Division(string num1, string num2)
        {

            double resultado = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            return resultado;

        }


    }
}
