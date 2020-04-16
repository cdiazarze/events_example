using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Example
{
    public class App1
    {
        //Pasos Suscriptor
        //1- Declarar un método que defina la acción a tomar si se dispara el evento.
        //Este método tiene que tener la misma firma que el delegate del evento.
        //2- Inscribir el o los métodos

        public void OnBatteryCheckedSuspend(object source, EventArgs args)
        {
            Console.WriteLine("Suspending my activities...");
        }
    }
}
