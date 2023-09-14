using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerLearn.Serialization;

namespace PowerLearnCreator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            Application.Run(new CreatorForm());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Helper.Clean();
        }
    }
}
