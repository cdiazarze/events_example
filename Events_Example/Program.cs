using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Cellphone cell = new Cellphone();
            Notifier notifier = new Notifier();
            App1 app1 = new App1();
            App1 app2 = new App1();

            cell.BatteryChecked += notifier.OnBatteryChecked;
            cell.BatteryChecked += app1.OnBatteryCheckedSuspend;
            cell.BatteryChecked += app2.OnBatteryCheckedSuspend;

            cell.CheckBattery();
        }
    }
}
