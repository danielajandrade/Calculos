using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{

    /// <summary>
    /// Impleneta operações aritmeica
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna o resultado da soma</returns>
        public static int Somar (int x, int y)
        { return x + y; }
        /// <summary>
        /// Operação subtrair
        /// </summary>
        /// <returns>Retorna o resultado da subtração</returns>
        public static int Subtrair (int x, int y)
        {
            return x - y;
        }


        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }
}
