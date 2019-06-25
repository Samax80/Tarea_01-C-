using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperacionesDLL;

namespace Calculadora_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Calculadora V 1.0");
            Console.WriteLine("Esta calculadora pedira dos numeros al usuario");
            Console.WriteLine("y en pantalla se mostrarara las diferentes operaciones en pantalla");
            Console.WriteLine("*************************************************************************");

            var numero1 = string.Empty;
            var numero2 = string.Empty;
            Console.WriteLine("Digite un numero1");
            numero1 = Console.ReadLine();
            Console.WriteLine("Digite un numero1");
            numero2 = Console.ReadLine();

                       
            //SUMA
            Operaciones oper = new Operaciones();
            var resultadosuma = oper.Suma(numero1, numero2);
       
                       
            //FUNCION SUMA ,sin parametros.
            Operaciones oper2 = new Operaciones();
            oper2.Mynumero1 = numero1;
            oper2.Mynumero2 = numero2;
            var resultadosumaSinparametros=oper2.Suma();


            //uso de la funcion SUMA "Estatica"
           var resultadoestatico= OperacionesEstaticas.Suma(numero1, numero2);


            Console.WriteLine("El resultado de la suma de " + numero1 + "+"+  numero2 + "" + " =" + resultadosuma.ToString());

            Console.WriteLine("llamando funcion SUMA sin parametros" +"="+ resultadosumaSinparametros.ToString());

            Console.WriteLine("Funcion SUMA estatica= "+ resultadoestatico);

                     
                       
           
             //RESTA
           
            var resultadoresta = oper.Resta(numero1, numero2);


            //FUNCION RESTA ,sin parametros.


            var resultadorestaSinparametros = oper2.Resta();


            //uso de la funcion RESTA "Estatica"
            var resultadoestaticoResta = OperacionesEstaticas.Resta(numero1, numero2);


            Console.WriteLine("El resultado de la RESTA de " + numero1 + "-" + numero2 + "" + " =" + resultadoresta.ToString());

            Console.WriteLine("llamando funcion RESTA sin parametros" + "=" + resultadorestaSinparametros.ToString());

            Console.WriteLine("Funcion RESTA estatica= " + resultadoestaticoResta);


            //Multiplicacion

           

            var resultadoMultiplicacion = oper.Multiplicacion(numero1, numero2);


            //FUNCION Multiplicacion ,sin parametros.


            var resultadoMultiplicacionSinparametros = oper2.Multiplicacion();


            //uso de la funcion Multiplicacion "Estatica"
            var resultadoestaticoresultadoMultiplicacion = OperacionesEstaticas.Multiplicacion(numero1, numero2);


            Console.WriteLine("El resultado de la Multiplicacion de " + numero1 + "*" + numero2 + "" + " =" + resultadoMultiplicacion.ToString());

            Console.WriteLine("llamando funcion Multiplicacion sin parametros" + "=" + resultadoMultiplicacionSinparametros.ToString());

            Console.WriteLine("Funcion Multiplicacion estatica= " + resultadoestaticoresultadoMultiplicacion);


            //Division



            var resultadoDivision = oper.Division (numero1, numero2);


            //FUNCION Division ,sin parametros.


            var resultadoDivisionSinparametros = oper2.Division();


            //uso de la funcion Division "Estatica"
            var resultadoestaticoresultadoDivision = OperacionesEstaticas.Division(numero1, numero2);


            Console.WriteLine("El resultado de la Division de " + numero1 + "/" + numero2 +  " =" + resultadoDivision.ToString());

            Console.WriteLine("llamando funcion Division sin parametros" + "=" + resultadoDivisionSinparametros.ToString());

            Console.WriteLine("Funcion RESTA estatica= " + resultadoestaticoresultadoDivision);

            Console.WriteLine("*******************************************************************");
            Console.WriteLine("FIN Calculadora V 1.0");

          

            Console.ReadLine();
           

        }
    }
}
