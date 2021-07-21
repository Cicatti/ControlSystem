using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontPage;
using WinFormsApp1;

namespace ControlSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_customer());
            frmLogin Form = new frmLogin();
            if (Form.ShowDialog() != DialogResult.OK)
            {
                if (Form.entry == "ok")
                {
                    Application.Run(new FrontpageForm());
                }
               else
                {
                    if (!(Form.entry != null || Form.entry != "False" ))
                    {
                        Form.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }     
                }
            }
            else
            {
                Application.Exit();
            }
            



        }
    }
}
