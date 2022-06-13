using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BTL_HDH
{
    internal class KeyboardHook
    {
        #region Khởi tạo các hàm từ thư viện win32

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x0100;

        #endregion Khởi tạo các hàm từ thư viện win32

        private bool isKatakana = false;

        private List<Keys> listOfKeys = new List<Keys>() { 0, 0, 0, 0, 0 };

        private KeyboardHookDelegate _hookProc;
        private IntPtr _hookHandle = IntPtr.Zero;

        public delegate IntPtr KeyboardHookDelegate(int nCode, IntPtr wParam, IntPtr lParam);

        // destructor
        ~KeyboardHook()
        {
            Uninstall();
        }

        public void Install(bool isKatakana = false)
        {x
            this.isKatakana = isKatakana;
            _hookProc = KeyboardHookProc;
            _hookHandle = SetupHook(_hookProc);
            if (_hookHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        private IntPtr SetupHook(KeyboardHookDelegate hookProc)
        {
            IntPtr hInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);

            return SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }

        private IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int VirtualKey = Marshal.ReadInt32(lParam);

                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    listOfKeys.Add((Keys)VirtualKey);
                    if (listOfKeys.Count > 5)
                        listOfKeys.RemoveAt(0);
                    JPChar jpchar = new JPChar(listOfKeys);
                    if (isKatakana ? jpchar.sendCharKatakana() : jpchar.sendCharHiragana())
                        return (IntPtr)1;
                }
            }

            return CallNextHookEx(_hookHandle, nCode, wParam, lParam);
        }

        public void Uninstall()
        {
            UnhookWindowsHookEx(_hookHandle);
        }
    }
}