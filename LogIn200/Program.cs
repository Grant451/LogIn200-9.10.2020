using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using LogIn200;

namespace LogIn200
{
    //change
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

            //CredentialsM model = new CredentialsM("Alice", "WonderLand");
            //CredentialsM model = new CredentialsM("Test", "Friday");
            LoginForm view = new LoginForm();
            
            //LogIn200 controller = new LogIn200(model, view);
            //view.SetController(controller);
            
            Application.Run(view);
            
        }
    }
}
