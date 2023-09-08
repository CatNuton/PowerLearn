using PowerLearn;
using PowerLearn.Serialization;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PowerLearnCandidate
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
            FileServer.Instance = new FileServer("130.61.26.111", "3001");
            if (args.Length == 0)
            {
                var edf = new EnterDataForm();
                edf.ShowDialog();
                if (edf.DialogResult == DialogResult.OK)
                {
                    var test = GetTestFromFile(edf.Path);
                    test.Candidate = edf.Candidate;
                    Application.Run(new TestForm(test));
                }
            }
            else
            {
                var test = GetTestFromFile(args[0]);
                test.Candidate = test.Author;
                Application.Run(new TestForm(test));
            }
        }

        private static Test GetTestFromFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                var s = new XmlSerializer(typeof(TestProxy));
                var sres = (TestProxy)s.Deserialize(sr);
                return sres.Test;
            }
        }
    }
}
