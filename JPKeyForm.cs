using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BTL_HDH
{
    public partial class JPKeyForm : Form
    {
        private static List<int> charater = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private static bool statusJPKey = true;

        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x0100;

        private static LowLevelKeyboardProc _proc = HookCallback;

        private static IntPtr _hookID = IntPtr.Zero;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]

        public static extern short GetKeyState(int keyCode);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            IntPtr a = new IntPtr();
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                CheckHotKey(vkCode);
                if (statusJPKey == true)
                {
                    if (CheckKey(vkCode) == true)
                        return lParam;
                    else
                        return a;
                }
            }
            return a;
        }

        static void HookKeyboard()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }
        static bool isHotKey_openwindow = false;
        static bool isShowing = false;
        static Keys previoursKey_openwindow = Keys.Separator;
        static bool isHotKey_Telex = false;
        static bool isTelex = false;
        static Keys previoursKey_Telex = Keys.Separator;

        static void CheckHotKey(int vkCode)
        {
            if ((previoursKey_openwindow == Keys.LControlKey || previoursKey_openwindow ==
            Keys.RControlKey) && (Keys)(vkCode) == Keys.K) //Ctrl+K
                isHotKey_openwindow = true;
            if (isHotKey_openwindow)
            {
                if (!isShowing)
                {
                    DisplayWindow();
                }
                else
                    HideWindow();

                isShowing = !isShowing;
            }
            previoursKey_openwindow = (Keys)vkCode;
            isHotKey_openwindow = false;
            if (previoursKey_Telex == Keys.LControlKey && (Keys)(vkCode) == Keys.LShiftKey)
                //Ctrl+Shift
                isHotKey_Telex = true;
            if (isHotKey_Telex)
            {
                if (!isTelex)
                {
                    statusJPKey = true;
                    Menu();
                }
                else
                {
                    statusJPKey = false;
                    Menu();
                }
                isTelex = !isTelex;
            }
            previoursKey_Telex = (Keys)vkCode;
            isHotKey_Telex = false;
            if ((Keys)(vkCode) == Keys.CapsLock)
            {
                Menu();
            }
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow(); //lấy ra màn hình console
        [DllImport("user32.dll")]
        static bool CheckKey(int vkCode)
        {
            bool capsLock = ((((ushort)GetKeyState(0x14)) & 0xffff) != 0); ///0x14
            charater.Add(vkCode);
            while (a.Count() > 10)
            {
                Text.RemoveAt(0);
            }
            if (vkCode == 83 & charater[charater.Count() - 2] == 65) //á
            {
                SendKeys.Send("{BACKSPACE}");
                if (capsLock != true)
                    SendKeys.Send("á");
                else
                    SendKeys.Send("Á");
                return true;
            }
        }
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void HideWindow()
        {
            IntPtr console = GetConsoleWindow();
            ShowWindow(console, SW_HIDE);
        }
        static void DisplayWindow()
        {
            IntPtr console = GetConsoleWindow();
            ShowWindow(console, SW_SHOW);// hiện window
        }

        public JPKeyForm()
        {
            InitializeComponent();
        }

        private void JPKeyForm_Load(object sender, EventArgs e)
        {
            HookKeyboard();
        }

        private void SQJPKey_button_Click(object sender, EventArgs e)
        {

        }
    }
}
