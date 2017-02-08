using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public static class Program
    {
        public static Variables variables = new Variables();

        //delegate void D(string value);
          
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());

            //D d = v => Console.WriteLine(v);
           // d.Invoke("cat");
        }
    }
}
