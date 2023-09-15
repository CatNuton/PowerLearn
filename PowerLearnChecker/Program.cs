using PowerLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnChecker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine(string.Join(",", args));
            FileServer.Instance = new FileServer("130.61.26.111", "3001");
            if (args.Length == 0)
            {
                Application.Run(new MainForm()); 
            }
            else
            {
                Application.Run(new MainForm(int.Parse(args[0]))); 
            }
        }
    }
}
