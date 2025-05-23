using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPSTONE_STOLE_ADMIN
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new SplashCard());*/
            Application.Run(new Main_DashBoard("fP9ZRKcGGtOVqomB0YIRy9o4GRa2"));
        }
    }
}
