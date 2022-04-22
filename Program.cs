using System;
using System.Windows.Forms;
using BTL_HDH;

namespace WindowsFormsApplication1
{
    internal sealed class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {
            Y2KeyboardHook keyboardHook = new Y2KeyboardHook();
            keyboardHook.Install();
            Application.Run();
        }

    }
}