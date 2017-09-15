using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1
{
    class Numero
    {
        private double numero;

        public double getNumero()
        {
            return this.numero;
        }

        /// <summary>
        /// constructor por default
        /// </summary>
        public Numero()
        {

        }

        /// <summary>
        /// constructor que setea a partir de un parametro recibido
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// constructor que parte el valor retornado de un textbox
        /// </summary>
        /// <param name="numero">numero que se obtiene de textbox</param>
        public Numero(string numero)
        {
            double auxiliarDouble = 0;

            if(double.TryParse(numero, out auxiliarDouble))
            {
                this.numero = auxiliarDouble;
            }

            
        }

        /// <summary>
        /// setea el valor recibido de un textbox pero primero lo valida
        /// </summary>
        /// <param name="numero">valor recibido de un textbox</param>
        private void setNumero(string numero)
        {
            double resultado = 0;

            resultado = validarNumero(numero);

            if (resultado != 0)
            {
                this.numero = Convert.ToDouble(numero);
            }
            
        }

        /// <summary>
        /// valida que que un string pueda parsearse a double
        /// </summary>
        /// <param name="numeroString">cadena a validar</param>
        /// <returns></returns>
        private double validarNumero(string numeroString)
        {
            double retorno = 0;
            double auxiliarDouble = 0;

            if(double.TryParse(numeroString,out auxiliarDouble))
            {
                retorno = 1;
            }

            return retorno;
        }
    }
}
