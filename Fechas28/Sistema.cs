using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas28
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            Console.ReadKey();
            DateTime fecha = Validador.ValidarFechaIngresada("\n Ingrese una Fecha");

            Console.Clear();
            Console.WriteLine("\n La fecha ingresada es: " + fecha.ToLongDateString());

            if (DateTime.IsLeapYear(fecha.Year))
            {
                Console.WriteLine("\n La fecha SI corresponde a un año bisieto");
            }
            else
            {
                Console.WriteLine("\n La fecha NO corresponde a un año bisieto");
            }

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
