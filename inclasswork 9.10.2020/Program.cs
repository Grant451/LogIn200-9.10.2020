using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inclasswork_9._10._2020
{

    public delegate void StateObs(State s);
    public delegate void InputHandler(State state, string args);


    /*
    // Create a method for a delegate.
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    // Instantiate the delegate.
    Del handler = DelegateMethod;

    // Call the delegate.
    handler("Hello World");
    */

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
            Credentialsd model = new Credentialsd("Alice", "Wonderland");
            Controllerd controller = new Controllerd(model);
            LogInD view = new LogInD(controller.handleEvents);
            controller.registeredObs(view.DisplayState);

            Application.Run(view);
        }
    }
}
