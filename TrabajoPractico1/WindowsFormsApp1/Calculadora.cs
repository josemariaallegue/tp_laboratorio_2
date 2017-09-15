using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    class Calculadora
    {
        /// <summary>
        /// a partir de numeros y un operador determina el resultado matematico
        /// </summary>
        /// <param name="numero1">Primer numero</param>
        /// <param name="numero2">Segundo numero</param>
        /// <param name="operador">El operador que determina la operacion</param>
        /// <returns>El resultado de la operacion</returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            double operador1 = numero1.getNumero();
            double operador2 = numero2.getNumero();

            Calculadora.validarOperador(operador);

            switch(operador)
            {
                case "+":
                    resultado = operador1 + operador2;
                    break;

                case "-":
                    resultado = operador1 - operador2;
                    break;

                case "*":
                    resultado = operador1 * operador2;
                    break;

                case "/":
                    resultado = operador1 / operador2;
                    break;

                default:
                    break;

            }

            return resultado;
        }

        /// <summary>
        /// valida que el operador sea +, -, * o /.
        /// </summary>
        /// <param name="operador">el operador a validar</param>
        /// <returns>si el operador recibido es valido devuelve el mismo si</returns>
        public static string validarOperador(string operador)
        {
            string retorno = "+";

            if(operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                retorno = operador;
            }
           
            return retorno;
        }
    }
}
