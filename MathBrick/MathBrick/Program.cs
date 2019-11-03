using System;
using System.Windows.Forms;

/* 
 * Author: Xinkai Wang
 * Description: The main entry point of the whole application.
*/

namespace MathBrick
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
