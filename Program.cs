using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTL_HDH
{
    static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Y2KeyboardHook keyboardHook = new Y2KeyboardHook(false,false);
            keyboardHook.Install();
            Application.Run(new JPKey());
        }

    }
}