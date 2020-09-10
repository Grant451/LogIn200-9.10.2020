using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInD
{
    public partial class LoginForm : Form
    {
        private InputHandler inHandler;

        public LogIn200(InputHandler);

        /// <summary>
        /// Listener to the Login button. It takes the user's input
        /// for the username and password and pass the values to the
        /// Controller along with the state the view is in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxLoginBtn_Click(object sender, EventArgs e)
        {
            String un = tbUserName.Text;
            String up = tbPassword.Text;
            Console.WriteLine(un + " " +up);
            controller.handleEvents(State.GOTPASSWORD, un+":"+up);

        }

        /// <summary>
        /// Links the View to the controller.
        /// </summary>
        /// <param name="c">The App's main controller object. Later
        /// this shold be a delegate.</param>
        public void SetController(Controller c)
        {
            controller = c;
        }

        /// <summary>
        /// TO synch the View and the Controller objects.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            controller.handleEvents(State.START, "");
        }

        /// <summary>
        /// This method helps avoid some user input propblems, and helps 
        /// keep the GUI in the right state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            controller.handleEvents(State.GOTUSERNAME, "");
        }


        /// <summary>
        /// This method helps avoid some user input propblems, and helps
        /// keep the GUI in the right state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            uxLoginBtn.Enabled = true;
        }

    }
}
