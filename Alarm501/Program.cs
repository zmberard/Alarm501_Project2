using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    /// <summary>
    /// Delegates
    /// </summary>
    /// <param name="state"></param>
    public delegate void DisplayState(State s, Alarm alarm);
    public delegate void handleMethodDel(State s, Alarm alarm);


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Alarm model = new Alarm(DateTime.Now);
            uxMainWindow m = new uxMainWindow();

            AlarmController controller = new AlarmController(m, m.DisplayStateDel);

            m.SetControllerDelegate(controller.handleEventsDel);
            controller.SetDisplayDelegate(m.DisplayStateDel);

            Application.Run(new uxMainWindow());
        }
    }
}
