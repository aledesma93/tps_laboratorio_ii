using System;

namespace EntidadesTP
{
    public class Calculadora
    {
        /// <summary>
        /// Validar que el operador recibido sea +, - , / o *. Caso contrario retorna + 
        /// </summary>
        /// <param name="operador">Operador ingresado a ser validado </param>
        /// <returns></returns>

        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = operador;
            }

            return retorno;
        }

       

        public double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado = ValidarOperador(operador);

            double resultado = 0;

            switch (operadorValidado)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
    }
}
