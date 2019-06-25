using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDLL
{
    public class Operaciones
    {
        /// <summary>
        /// Esta es la propiedad para Mynumero1
        /// </summary>
        public string Mynumero1 { get; set; }
        /// <summary>
        /// /// Esta es la propiedad para Mynumero2
        /// </summary>
        public string Mynumero2 { get; set; }

        public double Suma()
        {

            //double result = Convert.ToDouble(Mynumero1) + Convert.ToDouble(Mynumero2);
            double result = Suma(Mynumero1, Mynumero2);
            return result;

        }


        public  double Suma(double num1,double num2)
        {

            double result = num1 + num2;

            return result;

        }

        public double Suma(string num1,string num2)
        {

         double resultado= Suma(Convert.ToDouble(num1), Convert.ToDouble(num2));

         return resultado;
                        
        }


        //Resta
        public double Resta()
        {

            //double result = Convert.ToDouble(Mynumero1) + Convert.ToDouble(Mynumero2);
            double result = Resta(Mynumero1, Mynumero2);
            return result;

        }


        public double Resta(double num1, double num2)
        {

            double result = num1 - num2;

            return result;

        }

        public double Resta(string num1, string num2)
        {

            double resultado = Resta(Convert.ToDouble(num1), Convert.ToDouble(num2));

            return resultado;

        }


        //Multiplicacion

        public double Multiplicacion()
        {

            //double result = Convert.ToDouble(Mynumero1) + Convert.ToDouble(Mynumero2);
            double result = Multiplicacion(Mynumero1, Mynumero2);
            return result;

        }


        public double Multiplicacion(double num1, double num2)
        {

            double result = num1 * num2;

            return result;

        }

        public double Multiplicacion(string num1, string num2)
        {

            double resultado = Multiplicacion(Convert.ToDouble(num1), Convert.ToDouble(num2));

            return resultado;

        }


        //Division

        public double Division()
        {

            //double result = Convert.ToDouble(Mynumero1) + Convert.ToDouble(Mynumero2);
            double result = Division(Mynumero1, Mynumero2);
            return result;

        }

       
        public double Division(double num1, double num2)
        {

            double result = num1 / num2;

            return result;

        }

        public double Division(string num1, string num2)
        {

            double resultado = Division(Convert.ToDouble(num1), Convert.ToDouble(num2));

            return resultado;

        }



    }
}
