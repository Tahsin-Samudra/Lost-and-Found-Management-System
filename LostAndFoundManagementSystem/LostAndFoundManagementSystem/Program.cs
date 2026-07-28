using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LostAndFoundManagementSystem
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

            while(true)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new DashBoard());
                    }
                }

                using (var dash = new DashBoard())
                {
                    Application.Run(dash);
                    if (!dash.LoggedOut)
                        break; // dashboard closed normally -> exit app
                               // else loop to show login again
                }
            }
        }
    }
}
