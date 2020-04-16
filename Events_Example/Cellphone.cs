using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events_Example
{
    public class Cellphone
    {
        private Battery myBattery = new Battery() {Level = 0.12};

        //Pasos publisher
        //1- Definir el delegate
        public delegate void CheckedBatteryEventHandler(object source, BatteryEventArgs args);
        //2- Definir el evento basado en el delegate anterior
        public event CheckedBatteryEventHandler BatteryChecked;
        //3- Disparar el evento
        protected virtual void OnBatteryChecked(double batteryLevel)
        {
            //Revisar si existen suscriptores
            if (BatteryChecked != null)
            {
                BatteryChecked(this, new BatteryEventArgs(){BatteryLevel = batteryLevel});
            }
        }

        public void CheckBattery()
        {
            double batteryLevel = myBattery.Level*100;
            Console.WriteLine("My battery level is: " + batteryLevel + "%");
            Thread.Sleep(5000);
            if (batteryLevel <= 15)
            {
                Console.WriteLine("Send internal notification...");
                //Llamar el metodo que dispara el evento
                OnBatteryChecked(batteryLevel);
            }
            
        }
    }
}
